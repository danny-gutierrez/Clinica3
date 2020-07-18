using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Areas.Recepcionista.Controllers
{
    public class CitasController : Controller
    {
        private ClinicaContext _db = null;
        // GET: Citas
        public ActionResult Index()
        {
            IEnumerable<Cita> Citas = null;
            using(_db =new ClinicaContext())
            {
                Citas = _db.Citas.ToList();

            }
            return View(Citas);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Cita cita = new Cita();
            return View(cita);
        }

        [HttpPost]
        public ActionResult Create(Cita cita)
        {
            if (ModelState.IsValid)
            {
                //Guardo en base de datos
                //O mando Request a REST API
                return RedirectToAction("Index", "Citas", new { id = 1 });
            }

            return View(cita);
        }
        public ActionResult View(int id)
        {
            Cita c = null;
            using(_db=new ClinicaContext())
            {
                c = _db.Citas.Find(id);
            }
            return View(c);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            Cita c = null;
            using (_db = new ClinicaContext())
            {
                c = _db.Citas.Find(id);
            }
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(Cita cita)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Citas", new { id = 1 });
            }
            return View(cita);
        }


    }
}