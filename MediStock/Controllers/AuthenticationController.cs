using MediStockWeb.Controllers.Base;
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
        
        [HttpPost]
        public IActionResult SignUp(AuthenticationModel model)
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignIn(AuthenticationModel model)
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