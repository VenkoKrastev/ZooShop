
using Microsoft.AspNetCore.Mvc;
using ZooShop.Infrastructure.Data.Models;
using ZooShop.Core.Models;
using ZooShop.Infrastructure.Data;

namespace ZooShop.Controllers
{
    public class DogController : Controller
    {
        private readonly ZooShopDbContext _context;

        public DogController(ZooShopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var dogCategoryViewModel = new DogCategoryViewModel();
           

            return View(dogCategoryViewModel);
        }
    }
}
