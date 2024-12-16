using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShop.Core.Enums;
using ZooShop.Core.Models;
using ZooShop.Core.Models.ViewModels.QueryModels;

namespace ZooShop.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductIndexServiceModel>> LastThreeProduct();

        Task<ProductQueryServiceModel> AllAsync(
            string? imageUrl = null,
            string? price = null,
            ProductSorting sorting = ProductSorting.Newest,
            int currentPage = 1,
            int productPerPage = 10
            );
    }
}
