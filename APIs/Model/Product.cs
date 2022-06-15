using Microsoft.AspNetCore.Mvc;

namespace APIs.Model
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Group { get; set; }
        public string Status { get; set; }
        public FileContentResult Images { get; set; }
        public string Description { get; set; }
        public double CurrentPrice { get; set; }
        public double OriginalPrice { get; set; }

        public Product(string iD, string name, int group, string status, FileContentResult images, string description, double currentPrice, double originalPrice)
        {
            ID = iD;
            Name = name;
            Group = group;
            Status = status;
            Images = images;
            Description = description;
            CurrentPrice = currentPrice;
            OriginalPrice = originalPrice;
        }
    }
}
