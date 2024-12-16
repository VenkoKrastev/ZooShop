using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShop.Core.Models.ViewModels.QueryModels;
using ZooShop.Infrastructure.Data.Models;

namespace ZooShop.Core.Extensions
{
    public static class IQueryableProductExtension
    {
        public static IQueryable<ProductServiceModel> ProjectToProductServiceModel(this IQueryable<Product> products)
        {
            return products.Select(b => new ProductServiceModel()
            {
                Id = b.Id,
                Title = b.Name,
                Price = b.Price,
                ImageUrl = b.ImageUrl,
                Details = b.Description,

            });
        }
    }
}
