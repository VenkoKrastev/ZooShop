using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooShop.Infrastructure.Data;

namespace ZooShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ZooShopDbContext _context;

        public ProductController(ZooShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Details(int id)
        {
            var product = _context.Products
                              .Include(p => p.Category)
                              .Include(p => p.Accessory)
                              .FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
