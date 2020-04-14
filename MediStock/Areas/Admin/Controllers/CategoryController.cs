using MediStockWeb.Areas.Admin.Controllers.Base;
using MediStockWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediStockWeb.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        public IActionResult List()
        {
            var model = new CategoryModel();
            TempData["CategoryActiveMenuItem"] = "category-sidebar-id";
            return View(model);
        }

        public IActionResult CategoryList(CategoryModel searchModel)
        {
            return View(searchModel);
        }

        public IActionResult Create()
        {
            var model = new CategoryModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = new CategoryModel();
            return View();
        }

        [HttpPost]
        public IActionResult Edit(CategoryModel model)
        {
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}