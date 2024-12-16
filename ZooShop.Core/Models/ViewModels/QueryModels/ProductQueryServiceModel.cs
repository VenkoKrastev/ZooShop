using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShop.Core.Services;

namespace ZooShop.Core.Models.ViewModels.QueryModels
{
    public class ProductQueryServiceModel
    {
        public int TotalProductsCount { get; set; }
        public IEnumerable<ProductService> Products { get; set; } = new HashSet<ProductService>();
    }
}
