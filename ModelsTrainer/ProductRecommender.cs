using BLL;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsTrainer
{
    public class ProductInput
    {
        [KeyType(count: 262111)]
        public uint ProductId { get; set; }

        [KeyType(count: 262111)]
        public uint ProductIdCoPurchased { get; set; }
    }

    public class ProductPrediction
    {
        public float Score { get; set; }
    }

    public class ProductRecommender
    {
        private static readonly string projectFolder = Directory
    .GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName)
    .FullName;

        private static readonly string filePathTraningData = Path.Combine(projectFolder, @"Data\\SampleData2.txt");

        private static readonly string modelPath =
            Path.Combine(projectFolder, @"Data\\MLModelProductRecommender.zip");

        public static void Trainning()
        {
            // Create MLContext to be shared across the model creation workflow objects
            MLContext mlContext = new MLContext();

            // Read the trained data using TextLoader by defining the schema for reading the product co-purchase dataset
            Console.WriteLine("Loading data...");
            var trainData = mlContext.Data.LoadFromTextFile(path: filePathTraningData,
                columns: new[]
                {
                    new TextLoader.Column("Label", DataKind.Single, 0),
                    new TextLoader.Column(name:nameof(ProductInput.ProductId), dataKind:DataKind.UInt32, source: new [] { new TextLoader.Range(0) }, keyCount: new KeyCount(262111)),
                    new TextLoader.Column(name:nameof(ProductInput.ProductIdCoPurchased), dataKind:DataKind.UInt32, source: new [] { new TextLoader.Range(1) }, keyCount: new KeyCount(262111))
                },
                hasHeader: true,
                separatorChar: '\t');

            // Split the data into 80% training and 20% testing partitions
            var partitions = mlContext.Data.TrainTestSplit(trainData, testFraction: 0.2);

            // Specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
            MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options()
            {
                MatrixColumnIndexColumnName = "ProductIdEncoded",
                MatrixRowIndexColumnName = "ProductIdCoPurchasedEncoded",
                LabelColumnName = "Label",
                LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
                Alpha = 0.01,
                Lambda = 0.025
            };

            // Set up a training pipeline
            // Mapping ProductId and ProductIdCoPurchased to keys
            var pipeline = mlContext.Transforms.Conversion.MapValueToKey(
                    inputColumnName: "ProductId",
                    outputColumnName: "ProductIdEncoded")
                .Append(mlContext.Transforms.Conversion.MapValueToKey(
                    inputColumnName: "ProductIdCoPurchased",
                    outputColumnName: "ProductIdCoPurchasedEncoded"))
                // Find recommendations using matrix factorization
                .Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));

            // Train the model
            Console.WriteLine("Training the model...");
            ITransformer model = pipeline.Fit(partitions.TrainSet);

            // Save model
            mlContext.Model.Save(model, trainData.Schema, modelPath);

            //// evaluate the model performance
            //Console.WriteLine("Evaluating the model...");
            //var predictions = model.Transform(partitions.TestSet);
            //var metrics = mlContext.Regression.Evaluate(predictions, labelColumnName: "ProductIdCoPurchased", scoreColumnName: "Score");
            //Console.WriteLine($"  RMSE: {metrics.RootMeanSquaredError:#.##}");
            //Console.WriteLine($"  L1:   {metrics.MeanAbsoluteError:#.##}");
            //Console.WriteLine($"  L2:   {metrics.MeanSquaredError:#.##}");
            Console.WriteLine();

            // Check how well products 3 and {idCoPurchasedTest} go together
            var idCoPurchasedTest = 10;

            // Load model.
            using (var file = File.OpenRead(modelPath))
                model = mlContext.Model.Load(file, out DataViewSchema schema);

            Console.WriteLine("Predicting if two products combine...");
            // Create a prediction engine from the model for feeding new data.
            var engine = mlContext.Model
                .CreatePredictionEngine<ProductInput, ProductPrediction>(model);
            var prediction = engine.Predict(
                new ProductInput()
                {
                    ProductId = 3,
                    ProductIdCoPurchased = (uint)idCoPurchasedTest
                });
            Console.WriteLine($"Score of products 3 and {idCoPurchasedTest} co-purchased: {prediction.Score}");
            Console.WriteLine();

            // find the top 5 combined products for product 6
            Console.WriteLine("Calculating the top 5 products for product 3...");
            var top5 = (from m in Enumerable.Range(1, 25)
                        let p = engine.Predict(
                            new ProductInput()
                            {
                                ProductId = 3,
                                ProductIdCoPurchased = (uint)m
                            })
                        orderby p.Score descending
                        select (ProductID: m, Score: p.Score)).Take(5);
            foreach (var t in top5)
                Console.WriteLine($"  Score:{t.Score}\tProduct: {t.ProductID}");
            Console.ReadKey();
        }

        public static async Task GenerateSampleData()
        {
            List<string> data = new List<string> { "ProductId\tProductIdCoPurchased\n" };
            try
            {
                var products = SanPhamBLL.GetProducts();
                foreach (var product in products)
                {
                    var random = new Random();
                    var randomLoop = random.Next(1, products.Count);
                    for (var i = 0; i < randomLoop; i++)
                    {
                        random = new Random();
                        int randomProductIndex = products.IndexOf(product);
                        while (randomProductIndex == products.IndexOf(product))
                        {
                            randomProductIndex = random.Next(0, products.Count - 1);
                        }

                        data.Add($"{products.IndexOf(product) + 1}\t{products.IndexOf(products[randomProductIndex]) + 1}");
                    }
                }

                await File.WriteAllLinesAsync("SampleData.txt", data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}