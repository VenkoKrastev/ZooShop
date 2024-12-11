using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ZooShop.Infrastructure.Data.DataConstants;


namespace ZooShop.Infrastructure.Data.Models
{
    public class Product
    {
        [Key]
        [Comment("The current Product's Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ProductNameMaxLength)]
        [Comment("The name of product")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ProductDescriptionMaxLength)]
        [Comment("Product details")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("Available quantity of the product")]
        public int StockQuantity { get; set; }

        [Required]
        [Comment("The current Products price")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(ProductImageUrlMaxLength)]
        [Comment("The current picture of product")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AccessoryId { get; set; }

        [ForeignKey(nameof(AccessoryId))]
        public Accessory Accessory { get; set; } = null!;
    }
}
