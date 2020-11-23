using DevBase.Business.Interfaces;
using DevBase.Entities.Concrete;
using DevBase.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBase.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public CategoryController(ICategoryService categoryService,IProductService productService)
        {
            _productService = productService;
            _categoryService = categoryService; 
        }
        public IActionResult Index()
        {
            List<Category>categories=_categoryService.GetProductSuccess();
            List<CategoryListViewModel> models = new List<CategoryListViewModel>();
            foreach (var item in categories)
            {
                CategoryListViewModel model = new CategoryListViewModel
                {
                    Name = item.Name,
                    Product = item.Product,
                    ProductId = item.ProductId,
                    Id = item.Id

                };
                models.Add(model);
            }
            return View(models);
        }
        public IActionResult AddCategory()
        {
            
            ViewBag.Products =new SelectList(_productService.GetAll(),"Id","Name");
            return View(new CategoryAddViewModel());
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Save(new Category 
                {
                    Name=model.Name,
                    ProductId=model.ProductId,
                
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult EditCategory(int id)
        {
            var category= _categoryService.GetId(id);
            CategoryEditViewModel model = new CategoryEditViewModel
            {
                Id = category.Id,
                Name = category.Name,
                ProductId = category.ProductId

            };
            ViewBag.Products = new SelectList(_productService.GetAll(), "Id", "Name",category.ProductId);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditCategory(CategoryEditViewModel model) 
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(new Category()
                {
                    Id = model.Id,
                    Name = model.Name,
                    ProductId = model.ProductId
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            _categoryService.Delete(new Category { Id = id });
            return Json(null);
        }

        
       
    }
}
