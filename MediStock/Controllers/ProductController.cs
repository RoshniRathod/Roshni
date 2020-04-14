using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MediStockWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Medicine()
        {
            return View();
        }
    }
}