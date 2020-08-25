using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceSample.BusinessLogicLayer.Abstract;
using ECommerceSample.Entities.Concrete;
using ECommerceSample.MvcWebUi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerceSample.MvcWebUi.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        #region Product
        public IActionResult ListProducts()
        {
            var model = new ProductAndCategoryListViewModel
            {
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        public IActionResult AddProduct()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                //TempData.Add("message", "Product was successfully added!");
            }

            return RedirectToAction("AddProduct");
        }

        public IActionResult UpdateProduct(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                //TempData.Add("message", "Product was successfully updated!");
            }

            return RedirectToAction("ListProducts");
        }

        public IActionResult DeleteProduct(int productId)
        {
            _productService.Delete(_productService.GetById(productId));
            return RedirectToAction("ListProducts");
        }
        #endregion


        #region Category
        public IActionResult ListCategories()
        {
            var model = new CategoriesViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        public IActionResult AddCategory()
        {
            var model = new CategoriesViewModel
            {
                Category = new Category()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(category);
                //TempData.Add("message", "Category was successfully added!");
            }

            return RedirectToAction("AddCategory");
        }

        public IActionResult UpdateCategory(int categoryId)
        {
            var model = new CategoriesViewModel
            {
                Category = _categoryService.GetById(categoryId),
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(category);
                //TempData.Add("message", "Category was successfully updated!");
            }

            return RedirectToAction("ListCategories");
        }

        public IActionResult DeleteCategory(int categoryId)
        {
            _categoryService.Delete(_categoryService.GetById(categoryId));
            return RedirectToAction("ListCategories");
        }
        #endregion


        //TODO:
        //Ana sayfadaki view details
        //görsellik
        //db backup
        //açılış sayfası
        //vakit kalırsa authorization
    }
}
