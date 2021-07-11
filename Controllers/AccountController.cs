using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_payroll_management_system.Models;
using Online_payroll_management_system.DbFolder.DbOperations;

namespace Online_payroll_management_system.Controllers
{
    public class AccountController : Controller
    {
        AccountDbOps AccRepo = null;
        public AccountController()
        {
             AccRepo = new AccountDbOps();
        }
      

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AccountModel am)
        {
            bool i = AccRepo.validate_login(am);
            if (i)
            {
                ViewBag.auth = "Successfully Logged-in";
            }
            else
            {
                ViewBag.auth = "Login failed, UserId or password is wrong";

            }
            return View();
        }



        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(AccountModel am)
        {
            bool i = AccRepo.new_signUp(am);
            if (i)
            {
                ViewBag.auth = "Account Created";
            }
            else
            {
                ViewBag.auth = "userID Exist";
            }
            return View();
        }
    }
}