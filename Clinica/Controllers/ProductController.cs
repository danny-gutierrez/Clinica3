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
                return RedirectToAction("home1", "Administrador");
            }
            if (username.Equals("recepcion") && password.Equals("123"))
            {
                Session["username"] = "username";
                return RedirectToAction("home2", "Recepcionista");
            }
            if (username.Equals("odontologo") && password.Equals("123"))
            {
                Session["username"] = "username";
                return RedirectToAction("home", "Doctor") ;
            }
            else
            {
                ViewBag.error = "Usuario Invalido";
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