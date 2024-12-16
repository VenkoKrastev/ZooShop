using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop.Core.Models
{
    public class ProductIndexServiceModel
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
    }
}
