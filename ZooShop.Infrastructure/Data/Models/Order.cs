using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop.Infrastructure.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }  

        public List<OrderItem> Items { get; set; }

        public DateTime OrderDate  { get; set; } = DateTime.Now;
    }
}
