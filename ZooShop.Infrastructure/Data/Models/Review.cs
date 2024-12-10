using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop.Infrastructure.Data.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public int Rating { get; set; } // Between 1 and 5
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }


}
