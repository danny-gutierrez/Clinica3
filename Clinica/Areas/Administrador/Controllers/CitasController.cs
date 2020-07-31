using Clinica.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Clinica.Areas.Administrador.Controllers
{
    public class CitasController : Controller
    {
        //private ClinicaContext _db = null;
        private ClinicaContext _db = new ClinicaContext();
        // GET: Citas
        public ActionResult Index()
        {
            ClinicaContext _db = new ClinicaContext();
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            return View(_db.Citas.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {



            Cita cita = new Cita();

            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            return View(cita);
        }

        [HttpPost]
        public ActionResult Create(Cita cita)

        {

            if (ModelState.IsValid)
            {
                _db.Citas.Add(cita);
                //boleta.Fecha=DateTime.Today;
                _db.SaveChanges();
                return RedirectToAction("Index", "Citas", new { id = 1 });
            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            return View(cita);



        }
        public ActionResult View(int id)
        {
            Cita c = null;
            using (_db = new ClinicaContext())
            {
                c = _db.Citas.Find(id);
                List<Odontologo> odontologos = _db.Odontologos.ToList();
                ViewBag.odontologos = odontologos;
            }
            return View(c);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            Cita c = _db.Citas.Find(id);
            if(c==null)
            {
                return new HttpNotFoundResult();
            }

            
                List<Odontologo> odontologos = _db.Odontologos.ToList();
                ViewBag.odontologos = odontologos;
           


            return View(c);


        }

        [HttpPost]
        public ActionResult Edit(Cita cita)
        {
            if (ModelState.IsValid)
            {
                _db = new ClinicaContext();
                _db.Entry(cita).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("View", "Citas", new { id = 1 });
            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            return View(cita);

        }


    }
}