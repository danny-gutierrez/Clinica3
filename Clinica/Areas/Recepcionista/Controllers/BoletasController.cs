using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Areas.Recepcionista.Controllers
{
    public class BoletasController : Controller
    {
        private ClinicaContext _db = null;
        // GET: boletas
        
        public ActionResult Index()

        {
            IEnumerable<Boleta> Boletas = null;
            using (_db = new ClinicaContext())
            {
                Boletas = _db.Boletas.ToList();
            }
            return View(Boletas);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Boleta boleta = new Boleta();
            return View(boleta);
        }

        [HttpPost]
        public ActionResult Create(Boleta boleta)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Boletas", new { id = 1 });
            }
            return View(boleta);
        }
        public ActionResult View(int id)

        {
            Boleta b = null;
            using(_db=new ClinicaContext())
            {
                b = _db.Boletas.Find(id);
            }
            return View(b);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Boleta b = null;
            using (_db = new ClinicaContext())
            {
                b = _db.Boletas.Find(id);
            }
            return View(b);
        }

        [HttpPost]
        public ActionResult Edit(Boleta boleta)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Boletas", new { id = 1 });
            }
            return View(boleta);
        }
    }
}