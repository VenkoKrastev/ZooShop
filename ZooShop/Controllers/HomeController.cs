using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZooShop.Core.Contracts;
using ZooShop.Models;


namespace ZooShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(
            ILogger<HomeController> logger,
            IProductService _productService)
        {
            _logger = logger;
            productService = _productService;
            
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }
            var model = await productService.LastThreeProduct();
            return View(model);
            //var products = _context.Products
            //                   .OrderByDescending(p => p.Id)  // Подреждаме по най-новите продукти
            //                   .Take(5)  // Вземаме само последните 5 продукта
            //                   .ToList();

            //return View(products);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
