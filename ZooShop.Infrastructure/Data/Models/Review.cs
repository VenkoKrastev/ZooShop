namespace ZooShop.Infrastructure.Data.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public int Rating { get; set; } 
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }


}
