namespace APIs.Model
{
    public class ProductGroup
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Parent { get; set; }

        public ProductGroup(int iD, string name, int? parent)
        {
            ID = iD;
            Name = name;
            Parent = parent;
        }
    }
}
