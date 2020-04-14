using MediStockWeb.Areas.Admin.Controllers.Base;
using MediStockWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediStockWeb.Areas.Admin.Controllers
{
    public class MedicineController : BaseController
    {
        public IActionResult List()
        {
            var model = new MedicineModel();
            TempData["MedicineActiveMenuItem"] = "medicine-sidebar-id";
            return View(model);
        }

        public IActionResult MedicineList(MedicineModel searchModel)
        {
            return View(searchModel);
        }

        public IActionResult Create()
        {
            var model = new MedicineModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(MedicineModel model)
        {
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = new MedicineModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(MedicineModel model)
        {
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}