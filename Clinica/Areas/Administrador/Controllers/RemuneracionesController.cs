using Clinica.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Clinica.Areas.Administrador.Controllers
{
    public class RemuneracionesController : Controller

    {
        private ClinicaContext _db = new ClinicaContext();
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
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            return View(remuneracion);
        }

        [HttpPost]
        public ActionResult Create(Remuneracion remuneracion)
        {

            if (ModelState.IsValid)
            {
                //Guardo en base de datos
                //O mando Request a REST API
                return RedirectToAction("Index", "Remuneraciones", new { id = 1 });
            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
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
                List<Odontologo> odontologos = _db.Odontologos.ToList();
                ViewBag.odontologos = odontologos;
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
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            return View(remuneracion);

        }
    }
}