using BAL.Services;
using DAL.Domains;
using MediStockWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediStockWeb.Controllers
{
    public class UserController : Controller
    {
        #region Fields

        private readonly IUserService _userService;

        #endregion

        #region Ctor
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region Methods

        #region User CRUD

        [HttpPost]
        public ActionResult AddUser(CustomerModel model)
        {
            Customer obj = new Customer();
            if (ModelState.IsValid)
            {
                Customer objCustomerModel = new Customer
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Password = model.Password,
                    Phone = model.Phone,
                    City = model.City,
                    State = model.State,
                    Address = model.Address,
                    Zipcode = model.Zipcode,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                };

                var userData = _userService.AddUser(objCustomerModel);
                if (userData == null)
                {
                    TempData["Message"] = "The provided E-mail is already in use. Please provide another E-mail";
                    return RedirectToAction("SignUp", "Home", new { area = "" });
                }
                else
                {
                    TempData["Message"] = "Sign Up successfull. Please Sign In";
                    return RedirectToAction("SignIn", "Home", new { area = "" });
                }
            }

            TempData["Message"] = "Oops some error occured please try again...";
            return RedirectToAction("SignUp", "Home", new { area = "" });
        }

        public ActionResult EditUser(int CustomerID)
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Edit User Failed";
            }

            var model = new Customer();
            model = _userService.GetUserById(CustomerID);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditUser(Customer model)
        {
            if (ModelState.IsValid)
            {
                _userService.UpdateUser(model);
                return RedirectToAction("Index", "User");
            }
            return View();
        }

        [HttpPost]
        public ActionResult DeleteUser(Customer model)
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Delete User Failed";
            }
            _userService.DeleteUser(model.Id);
            return RedirectToAction("Index", "User");
        }

        #endregion

        //#region User Authentication

        //[HttpPost]
        //public ActionResult SignIn(CustomerModel model)
        //{
        //    Customer obj = new Customer();

        //    if (ModelState.IsValid)
        //    {
        //        obj.Email = model.Email;
        //        obj.Password = model.Password;
        //        var userData = _userService.SignIn(obj);
        //        obj = userData;
        //    }

        //    if (obj == null)
        //    {
        //        TempData["ErrorMessage"] = "Sign In failed ! Password or Email is incorrect";
        //        return RedirectToAction("SignIn", "Home", new { area = "" });
        //    }
        //    else
        //    {
        //        if (obj.IsActive == true && obj.IsDeleted == false)
        //        {
        //            Session["Id"] = obj.Id.ToString();
        //            Session["UserName"] = obj.FirstName.ToString();
        //            return RedirectToAction("Index", "Admin", new { area = "Admin" });
        //        }
        //        else if (obj.isActive == true && obj.isDeleted == false)
        //        {
        //            Session["UserID"] = obj.UserID.ToString();
        //            Session["UserName"] = obj.fullName.ToString();
        //            return RedirectToAction("Index", "RegUser", new { area = "" });
        //        }
        //        else
        //        {
        //            return RedirectToAction("SignIn", "Home", new { area = "" });
        //        }
        //    }
        //}

        //[HttpPost]
        //public ActionResult RecoverPassword(CustomeModel model)
        //{
        //    Customer obj = new Customer();

        //    if (ModelState.IsValid)
        //    {
        //        obj.Email = model.Email;
        //        var userData = _userService.EmailExists(obj);
        //        obj = userData;
        //    }

        //    if (obj == null)
        //    {
        //        TempData["NoSuchEmailExists"] = "No Such Email Exists";
        //        return RedirectToAction("RecoverPassword", "Home", new { area = "" });
        //    }
        //    else
        //    {
        //        // Token Generation code
        //        int _min = 1000;
        //        int _max = 9999;
        //        Random _rdm = new Random();
        //        var token = _rdm.Next(_min, _max);
        //        TempData["OTP"] = token;

        //        string email, From, Subject, Body, To, UserID, Password, SMTPPort, Host;
        //        From = ConfigurationManager.AppSettings.Get("FromEmail");
        //        email = obj.email.ToString();
        //        Subject = ConfigurationManager.AppSettings.Get("RecoveryPasswordEmailSubject");
        //        Body = ConfigurationManager.AppSettings.Get("RecoveryPasswordEmailBody") + token;
        //        To = obj.email.ToString();
        //        UserID = ConfigurationManager.AppSettings.Get("FromUserId");
        //        Password = ConfigurationManager.AppSettings.Get("FromPassword");
        //        SMTPPort = ConfigurationManager.AppSettings.Get("FromSMTPPort");
        //        Host = ConfigurationManager.AppSettings.Get("FromHost");

        //        // For carrying further the email to update password in database.
        //        TempData["userEmail"] = email;

        //        EmailManager emailObj = new EmailManager();

        //        // call to function which sends email -> emailObj.AppSettings(out UserID, out Password, out SMTPPort, out Host);
        //        emailObj.SendEmail(From, Subject, Body, To, UserID, Password, SMTPPort, Host);
        //    }

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult UpdatePassword(UserViewModel model)
        //{
        //    string userEmail = TempData["userEmail"].ToString();

        //    // Update password code goes here
        //    bool result = false;
        //    if (ModelState.IsValid)
        //    {
        //        // Model Prepration
        //        User objUserModel = new User
        //        {
        //            email = userEmail,
        //            password = model.password,
        //            updatedOn = DateTime.Now
        //        };

        //        bool userData = _userService.UpdateUserPassword(objUserModel);
        //        result = userData;
        //    }

        //    if (result == false)
        //        return RedirectToAction("UpdatePassword", "Home", new { area = "" });
        //    else
        //    {
        //        TempData["PasswordUpdated"] = "Password updated successfully... Please Login";
        //        return RedirectToAction("SignIn", "Home", new { area = "" });
        //    }
        //}

        //#endregion


        #endregion

    }
}
