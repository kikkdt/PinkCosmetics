using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.TimeSeries;

string projectFolder = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName;
string filePath = Path.Combine(projectFolder, @"Data\\data.csv");
string modelPath = Path.Combine(projectFolder, @"Data\\MLModel.zip");

MLContext mlContext = new MLContext();

IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(filePath, hasHeader: true, separatorChar: ',');

// The data of April and March for training
IDataView firstMonthData = mlContext.Data.FilterRowsByColumn(dataView, "month", upperBound: 5);
// The data of May for testing
IDataView secondMonthData = mlContext.Data.FilterRowsByColumn(dataView, "month", lowerBound: 5);

var forecastingPipeline = mlContext.Forecasting.ForecastBySsa(
    outputColumnName: nameof(ModelOutput.ForecastedSales),
    inputColumnName: nameof(ModelInput.sales),
    windowSize: 2,
    seriesLength: 30,
    trainSize: 80,
    horizon: 7,
    confidenceLevel: 0.95f,
    confidenceLowerBoundColumn: nameof(ModelOutput.LowerBoundSales),
    confidenceUpperBoundColumn: nameof(ModelOutput.UpperBoundSales));

SsaForecastingTransformer forecaster = forecastingPipeline.Fit(firstMonthData);

Evaluate(secondMonthData, forecaster, mlContext);

var forecastEngine = forecaster.CreateTimeSeriesEngine<ModelInput, ModelOutput>(mlContext);
forecastEngine.CheckPoint(mlContext, modelPath);

Forecast(secondMonthData, 7, forecastEngine, mlContext);

void Evaluate(IDataView testData, ITransformer model, MLContext mlContext)
{
    // Make predictions
    IDataView predictions = model.Transform(testData);

    // Actual values
    IEnumerable<float> actual =
        mlContext.Data.CreateEnumerable<ModelInput>(testData, true)
            .Select(observed => observed.sales);

    // Predicted values
    IEnumerable<float> forecast =
        mlContext.Data.CreateEnumerable<ModelOutput>(predictions, true)
            .Select(prediction => prediction.ForecastedSales[0]);

    // Calculate error (actual - forecast)
    var metrics = actual.Zip(forecast, (actualValue, forecastValue) => actualValue - forecastValue);

    // Get metric averages
    var MAE = metrics.Average(error => Math.Abs(error)); // Mean Absolute Error
    var RMSE = Math.Sqrt(metrics.Average(error => Math.Pow(error, 2))); // Root Mean Squared Error

    // Output metrics
    Console.WriteLine("Evaluation Metrics");
    Console.WriteLine("---------------------");
    Console.WriteLine($"Mean Absolute Error: {Utilities.FormatWithThousandSeparator(MAE)}");
    Console.WriteLine($"Root Mean Squared Error: {Utilities.FormatWithThousandSeparator(RMSE)}\n");
}

void Forecast(IDataView testData, int horizon, TimeSeriesPredictionEngine<ModelInput, ModelOutput> forecaster, MLContext mlContext)
{
    ModelOutput forecast = forecaster.Predict();

    IEnumerable<string> forecastOutput =
        mlContext.Data.CreateEnumerable<ModelInput>(testData, reuseRowObject: false)
            .Take(horizon)
            .Select((ModelInput sales, int index) =>
            {
                string date = $"{sales.year}/{sales.month}/{sales.day}";
                float actualSales = sales.sales;
                float lowerEstimate = Math.Max(0, forecast.LowerBoundSales[index]);
                float estimate = forecast.ForecastedSales[index];
                float upperEstimate = forecast.UpperBoundSales[index];
                return $"Date: {date}\n" +
                       $"Actual Sales: {Utilities.FormatWithThousandSeparator(actualSales)}\n" +
                       $"Lower Estimate: {Utilities.FormatWithThousandSeparator(lowerEstimate)}\n" +
                       $"Forecast: {Utilities.FormatWithThousandSeparator(estimate)}\n" +
                       $"Upper Estimate: {Utilities.FormatWithThousandSeparator(upperEstimate)}\n";
            });

    // Output predictions
    Console.WriteLine("Testing Sales Forecast");
    Console.WriteLine("---------------------");
    foreach (var prediction in forecastOutput)
    {
        Console.WriteLine(prediction);
    }
}

public static class Utilities
{
    /// <summary>
    /// Format number with thousand separator
    /// </summary>
    /// <param name="number">Number</param>
    /// <param name="currencyUnit">Currency unit</param>
    /// <returns></returns>
    public static string FormatWithThousandSeparator(double number, string currencyUnit = null)
    {
        return string.Format("{0:#,##0}" + (string.IsNullOrEmpty(currencyUnit) ? string.Empty : " " + currencyUnit), number);
    }
}

public class ModelInput
{
    [LoadColumn(0)] public string id;
    [LoadColumn(1)] public float year;
    [LoadColumn(2)] public float month;
    [LoadColumn(3)] public float day;
    [LoadColumn(4)] public float sales;
}

public class ModelOutput
{
    public float[] ForecastedSales { get; set; }

    public float[] LowerBoundSales { get; set; }

    public float[] UpperBoundSales { get; set; }
}