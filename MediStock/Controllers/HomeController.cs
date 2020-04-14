using DAL.Data;
using DAL.Domains;
using MediStockWeb.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MediStockWeb.Controllers
{
    public class HomeController : BaseController
    {
        private MediStockContext context;

        public HomeController(MediStockContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            //Log log1 = new Log() {

            //    CreatedOn = DateTime.UtcNow,
            //    LogLevel = 2,
            //    Message = "1st Data inserted successfully"
            //};
            //context.Remove(log1);
            //context.SaveChanges();

           

            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}