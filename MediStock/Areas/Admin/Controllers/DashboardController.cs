using MediStockWeb.Areas.Admin.Controllers.Base;
using MediStockWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediStockWeb.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            var model = new DashboardViewModel();
            TempData["DashboardActiveMenuItem"] = "dashboard-sidebar-id";
            return View(model);
        }
    }
}