using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooShop.Core.Contracts;
using ZooShop.Core.Models.ViewModels.QueryModels;
using ZooShop.Core.Services;
using ZooShop.Infrastructure.Data;
using ZooShop.Infrastructure.Data.Models;


namespace ZooShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        private readonly ZooShopDbContext _context;

        public ProductController(ZooShopDbContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;
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
        //public IActionResult AllProductView(string category)
        //{
        //    var products = _context.Products
        //.Where(p => p.Category.Name == category)
        //.ToList();

        //    if (products == null || !products.Any())
        //    {
        //        ViewBag.Message = "Няма продукти за тази категория.";
        //    }

        //    ViewBag.CategoryName = category;

        //    return View(products);
        //}
        //[HttpGet]
        //public IActionResult AllProductView(string category, string accessory)
        //{
        //    if (string.IsNullOrEmpty(category))
        //    {
        //        return View("Error");
        //    }


        //    var selectedCategory = _context.Categories
        //        .FirstOrDefault(c => c.Name == category);

        //    if (selectedCategory == null)
        //    {
        //        return View("Error");
        //    }


        //    var selectedAccessory = string.IsNullOrEmpty(accessory)
        //        ? null
        //        : _context.Accessories.FirstOrDefault(a => a.Name == accessory);


        //    var productsQuery = _context.Products
        //        .Where(p => p.CategoryId == selectedCategory.Id);


        //    if (selectedAccessory != null)
        //    {
        //        productsQuery = productsQuery.Where(p => p.AccessoryCategories
        //            .Any(ac => ac.AccessoriesId == selectedAccessory.Id));
        //    }

        //    var products = productsQuery.ToList();


        //    ViewBag.CategoryName = category;
        //    ViewBag.AccessoryName = accessory;

        //    return View(products);
        //}



        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductFormModel()
            {
                Categories = await _productService.AllAccessoriesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            if (await _productService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
            }

            if (ModelState.IsValid == false)
            {
                model.Categories = await _productService.AllAccessoriesAsync();

                return View(model);
            }

            int newProductId = await _productService.CreateAsync(model);

            return RedirectToAction("All", "Product");
        }




        //[HttpGet]
        //public IActionResult AllProductView(int categoryId)
        //{

        //    var products = _context.Products
        //        .Where(p => p.CategoryId == categoryId)
        //        .ToList();
        //    return View(products);

        //}

    }
}
