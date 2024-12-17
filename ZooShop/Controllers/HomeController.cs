using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZooShop.Core.Contracts;
using ZooShop.Core.Models;
using ZooShop.Core.Services;
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
            
        }

        public IActionResult ProductsByCategory(string category)
        {
            var products = productService.GetProductsByCategory(category);
            return View(products);  // Прехвърляме списъка с продукти към изгледа
        }

        [HttpGet]
        public IActionResult Search(string searchTerm)
        {
            var products = productService.SearchProducts(searchTerm);

            var productModels = products.Select(p => new ProductIndexServiceModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                ImageUrl = p.ImageUrl
            }).ToList();

            return View(productModels);
        }

        //[AllowAnonymous]
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}


    }
}
