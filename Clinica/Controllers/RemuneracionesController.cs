using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class RemuneracionesController : Controller

    {
        private ClinicaContext _db = null;
        // GET: Remuneraciones
        public ActionResult Index()
        {
            IEnumerable<Remuneracion> remuneracions = null;
            using (_db = new ClinicaContext())
            {
                remuneracions = _db.Remuneraciones.ToList();
            }
            return View(remuneracions);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Remuneracion remuneracion = new Remuneracion();
            return View(remuneracion);     
        }

        [HttpPost]
        public ActionResult Create(Remuneracion remuneracion)
        {
            if (ModelState.IsValid)
            {
                //Guardo en base de datos
                //O mando Request a REST API
                return RedirectToAction("Index", "Remuneraciones");
            }

            return View(remuneracion);
        }


        public ActionResult View(int id)
        {
            Remuneracion r = null;
            using (_db = new ClinicaContext())
            {
                r = _db.Remuneraciones.Find(id);
            }
            return View(r);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Remuneracion r = null;
            using (_db = new ClinicaContext())
            {
                r = _db.Remuneraciones.Find(id);
            }
            return View(r);
        }

        [HttpPost]
        public ActionResult Edit(Remuneracion remuneracion)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Remuneraciones", new { id = 1 });
            }
            return View(remuneracion);
        }
    }
}