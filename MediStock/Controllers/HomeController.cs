using BAL.Services;
using DAL.Data;
using DAL.Domains;
using MediStockWeb.Areas.Admin.Models;
using MediStockWeb.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MediStockWeb.Controllers
{
    public class HomeController : BaseController
    {
        #region Fields
        private readonly ICategoryService _categoryService;
        private readonly MediStockContext _context;
        //const int pageSize = 3;

        #endregion

        #region Ctor
        public HomeController(ICategoryService categoryService, MediStockContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }
        #endregion
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Category category)
        {
            return ViewComponent("CategoryMenu");
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