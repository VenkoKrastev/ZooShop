using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ZooShop.Infrastructure.Data.DataConstants;


namespace ZooShop.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        [Comment("The current Category's Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryMaxLength)]
        [Comment("The Name of product category")]
        public string Name { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
