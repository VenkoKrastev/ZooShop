using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShop.Infrastructure.Data.Models;

namespace ZooShop.Core.Models
{
    public class DogCategoryViewModel
    {
        public IEnumerable<Product> DogFood { get; set; }
        public IEnumerable<Accessory> DogAccessories { get; set; }
        public IEnumerable<Product> AllDogProducts { get; set; }
    }
}
