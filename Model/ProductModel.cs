 namespace PearlPineproject.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public required string  Name { get; set; }
        public int Price { get; set; }
        public required string Image {  get; set; }
        public int Stock { get; set; }
        public required string Category { get; set; }
    }
}


