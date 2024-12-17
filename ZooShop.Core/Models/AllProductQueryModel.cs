using System.ComponentModel.DataAnnotations;
using ZooShop.Core.Enums;
using ZooShop.Core.Models.ViewModels.QueryModels;

namespace ZooShop.Core.Models
{
    public class AllProductQueryModel
    {
        public int ProductPerPage { get; } = 10;

        [Display(Name = "Количество")]
        public int TotalProductsCount { get; set; }

        [Display(Name = "Търсене")]
        public string SearchTerm { get; set; } = null!;
        [Display(Name = "Сортиране")]
        public ProductSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public string Price { get; set; } = null!;

        [Display(Name = "Снимка")]
        public string ImageUrl { get; set; } = null!;

        public IEnumerable<ProductServiceModel> Products { get; set; } = new List<ProductServiceModel>();
    }
}
