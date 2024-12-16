using System.ComponentModel.DataAnnotations;
using ZooShop.Core.Contracts;
using static ZooShop.Infrastructure.Data.DataConstants;


namespace ZooShop.Core.Models.ViewModels.QueryModels
{
    public class ProductServiceModel : IProductModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ProductNameMaxLength, MinimumLength = ProductNameMinLength, ErrorMessage = LengthErrorMessage)]
        public string Title { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), ProductPriceMinValue, ProductPriceMaxValue, ErrorMessage = RangeErrorMessage)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(ProductImageUrlMaxLength, MinimumLength = ProductImageUrlMinLength, ErrorMessage = LengthErrorMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [StringLength(ProductDescriptionMaxLength, MinimumLength = ProductDescriptionMinLength, ErrorMessage = LengthErrorMessage)]
        public string Details { get; set; }
    }
}
