using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Areas.Recepcionista.Controllers
{
    public class PacientesController : Controller
    {
        private ClinicaContext _db = null;


        public ActionResult Index()
        {
            IEnumerable<Paciente> Pacientes = null;
            using (_db = new ClinicaContext())
            {
                Pacientes = _db.Pacientes.ToList();
            }
            return View(Pacientes);
        }

        [HttpGet]

        public ActionResult Create()
        {

            Paciente paciente = new Paciente();

            return View(paciente);
        }

        [HttpPost]
        public ActionResult Create(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Create", "Pacientes", new { id = 1 });
            }
            return View(paciente);
        }

        public ActionResult View(int id)
        {
            Paciente p = null;
            using (_db = new ClinicaContext())
            {
                p = _db.Pacientes.Find(id);
            }
            return View(p);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Paciente p = null;
            using (_db = new ClinicaContext())
            {
                p = _db.Pacientes.Find(id);
            }
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Edit", "Pacientes", new { id = 1 });
            }
            return View(paciente);
        }
    }
}