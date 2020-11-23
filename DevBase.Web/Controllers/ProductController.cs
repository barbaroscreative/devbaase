using DevBase.Business.Interfaces;
using DevBase.Entities.Concrete;
using DevBase.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBase.Web.Controllers
{
 
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            List<Product> products= _productService.GetAll();
            List<ProductListViewModel> model = new List<ProductListViewModel>();

            foreach (var item in products)
            {
                ProductListViewModel productModel = new ProductListViewModel();
                productModel.Id = item.Id;
                productModel.Name = item.Name;
                productModel.Brand = item.Brand;
                productModel.Description = item.Description;
                model.Add(productModel);
            }
            return View(model);
        }

        public IActionResult AddProduct()
        {
            return View(new ProductAddViewModel());
        }

        [HttpPost]
        public IActionResult AddProduct(ProductAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _productService.Save(new Product()
                {
                    Brand = model.Brand,
                    Name = model.Name,
                    Description = model.Description
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult EditProduct(int id)
        {
           var  product= _productService.GetId(id);
            ProductEditViewModel model = new ProductEditViewModel
            {
                Id = product.Id,
                Brand = product.Brand,
                Name = product.Name,
                Description = product.Description

            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditProduct(ProductEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(new Product
                {
                    Id = model.Id,
                    Brand = model.Brand,
                    Name = model.Name,
                    Description = model.Description
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
