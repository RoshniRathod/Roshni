using MediStockWeb.Areas.Admin.Controllers.Base;
using MediStockWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediStockWeb.Areas.Admin.Controllers
{
    public class OrderController : BaseController
    {
        public IActionResult List()
        {
            var model = new OrderModel();
            TempData["OrderActiveMenuItem"] = "order-sidebar-id";
            return View(model);
        }
        
        [HttpPost]
        public IActionResult OrderList(OrderModel searchModel)
        {
            return View(searchModel);
        }
        public IActionResult Create()
        {
            var model = new OrderModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(OrderModel model)
        {
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = new OrderModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(OrderModel model)
        {
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}