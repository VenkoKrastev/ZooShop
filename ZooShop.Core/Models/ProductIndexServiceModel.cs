namespace ZooShop.Core.Models
{
    public class ProductIndexServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    
        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
    }
}
