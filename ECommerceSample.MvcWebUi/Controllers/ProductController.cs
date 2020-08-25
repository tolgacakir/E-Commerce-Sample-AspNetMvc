using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceSample.BusinessLogicLayer.Abstract;
using ECommerceSample.MvcWebUi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceSample.MvcWebUi.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index(short categoryId=0)
        {
            var model = new ProductAndCategoryListViewModel
            {
                Products = _productService.GetByCategoryId(categoryId),
                Categories = _categoryService.GetAll(),
                
            };
            model.CurrentCategory = model.Categories.FirstOrDefault(c => c.Id == categoryId);

            return View(model);
        }
    }
}
