namespace JB.Models.DTO
{
    public class ProductDTO
    {
        public ProductDTO(int id, string name, string description, decimal price, int stockQuantity)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
        }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

     
    }
}
