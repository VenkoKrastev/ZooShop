using Microsoft.EntityFrameworkCore;
using ZooShop.Core.Contracts;
using ZooShop.Core.Enums;
using ZooShop.Core.Extensions;
using ZooShop.Core.Models;
using ZooShop.Core.Models.ViewModels.QueryModels;
using ZooShop.Infrastructure.Data.Common;
using ZooShop.Infrastructure.Data.Models;

namespace ZooShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repository;

        public ProductService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<ProductIndexServiceModel>> LastThreeProduct()
        {
            return await repository.AllReadOnly<Product>()
                .OrderByDescending(p => p.Id)
                .Take(5)
                .Select(p => new ProductIndexServiceModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price
                })
                .ToListAsync();
        }

        public async Task<ProductQueryServiceModel> AllAsync(string? imageUrl,
            string price,
            ProductSorting sorting = ProductSorting.Newest,
            int currentPage = 1,
            int productPerPage = 10)
        {
            var productToShow = repository.AllReadOnly<Product>();

            if (!string.IsNullOrEmpty(imageUrl))
            {
                productToShow = productToShow.Where(p => p.ImageUrl == imageUrl);
            }

            if (!string.IsNullOrEmpty(price))
            {
                productToShow = productToShow.Where(p => p.Price.ToString() == price);
            }

            productToShow = sorting switch
            {
                ProductSorting.Oldest => productToShow.OrderBy(p => p.Id),
                ProductSorting.PriceAscending => productToShow.OrderBy(p => p.Price),
                ProductSorting.PriceDescending => productToShow.OrderByDescending(p => p.Price),
                _ => productToShow.OrderByDescending(p => p.Id)
            };

            var products = await productToShow
                .Skip((currentPage - 1) * productPerPage)
                .Take(productPerPage)
                .ProjectToProductServiceModel()
                .ToListAsync();

            int totalProducts = await productToShow.CountAsync();

            return new ProductQueryServiceModel()
            {
                //Products = products,
                TotalProductsCount = totalProducts
            };

        }



        



    }
}
