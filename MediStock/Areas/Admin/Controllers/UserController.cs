using MediStockWeb.Areas.Admin.Controllers.Base;
using MediStockWeb.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediStockWeb.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        #region CRUD

        public IActionResult List()
        {
            var model = new UserModel();
            TempData["UserActiveMenuItem"] = "user-sidebar-id";
            return View(model);
        }

        [HttpPost]
        public IActionResult UserList(UserModel searchModel)
        {
            return View(searchModel);
        }

        public IActionResult Create()
        {
            var model = new UserModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(UserModel model)
        {
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = new UserModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UserModel model)
        {
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

        #endregion

        #region Profile

        public IActionResult Profile(int id)
        {
            var model = new UserProfileModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Profile(UserProfileModel model)
        {
            return View(model);
        }

        #endregion
    }
}