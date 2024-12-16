using Microsoft.AspNetCore.Mvc;
using ZooShop.Infrastructure.Data;

namespace ZooShop.Controllers
{
    public class AccessoryController : Controller
    {
        private readonly ZooShopDbContext _context;

        public AccessoryController(ZooShopDbContext context)
        {
            _context = context;
        }

        // Метод за показване на аксесоари и продукти в зависимост от избора на категория и аксесоар
        public IActionResult Index(string category, string accessory)
        {
            if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(accessory))
            {
                return BadRequest("Няма избрана категория или аксесоар.");
            }

            // Извличаме съответната категория и аксесоар от базата данни
            var selectedCategory = _context.Categories.FirstOrDefault(c => c.Name == category);
            var selectedAccessory = _context.Accessories.FirstOrDefault(a => a.Name == accessory);

            if (selectedCategory == null || selectedAccessory == null)
            {
                return NotFound("Категорията или аксесоарът не са намерени.");
            }

            // Вземаме всички продукти, които съвпадат с избраната категория и аксесоар
            var products = _context.Products
                                   .Where(p => p.CategoryId == selectedCategory.Id && p.AccessoryId == selectedAccessory.Id)
                                   .ToList();

            // Подаване на резултатите към изгледа
            ViewBag.CategoryName = category;
            ViewBag.AccessoryName = accessory;

            return View(products);
        }
    }
}
