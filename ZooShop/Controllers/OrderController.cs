using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooShop.Infrastructure.Data;

namespace ZooShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ZooShopDbContext _context;

        public OrderController(ZooShopDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _context.Orders.Include(o => o.User).Include(o => o.Items).ThenInclude(i => i.Product).ToListAsync();
            return View(orders);
        }

    }
}
