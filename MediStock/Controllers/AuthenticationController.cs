using MediStockWeb.Controllers.Base;
using MediStockWeb.Models;
using MediStockWeb.Models.Auth;
using Microsoft.AspNetCore.Mvc;

namespace MediStockWeb.Controllers
{
    public class AuthenticationController : BaseController
    {
        public IActionResult Auth()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignUp(CustomerModel model)
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignIn(CustomerModel model)
        {
            return RedirectToAction(nameof(Auth));
        }
        
        public IActionResult ForgotPassword()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult ForgotPassword(AuthenticationModel model)
        {
            return View();
        }
    }
}