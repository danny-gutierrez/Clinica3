using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinica.Models;

namespace Clinica.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username.Equals("danny") && password.Equals("123"))
            {
                Session["username"] = "username";
                return View("Success");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Index");
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Remove("username");
            return RedirectToAction("Index");
        }

    }
}