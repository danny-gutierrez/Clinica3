using Clinica.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Clinica.Areas.Administrador.Controllers
{
    public class BoletasController : Controller
    {
        private ClinicaContext _db = new ClinicaContext();
        // GET: boletas

        public ActionResult Index()

        {
            ClinicaContext _db = new ClinicaContext();
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            return View(_db.Boletas.ToList());

           // IEnumerable<Boleta> Boletas = null;
            //using (_db = new ClinicaContext())
           /* {
                Boletas = _db.Boletas.ToList();
            }
            return View(Boletas);*/
        }
        [HttpGet]
        public ActionResult Create()
        {
            Boleta boleta = new Boleta();
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            
            List<Paciente> pacientes = _db.Pacientes.ToList();
            ViewBag.pacientes = pacientes;



            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
            ViewBag.tratamientos = tratamientos;


            return View(boleta);
        }

        [HttpPost]
        public ActionResult Create(Boleta boleta)
        {

            if (ModelState.IsValid)
            {
                _db.Boletas.Add(boleta);
                 //boleta.Fecha=DateTime.Today;
                _db.SaveChanges();

                return RedirectToAction("Index", "Boletas", new { id = 1 });
            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            List<Paciente> pacientes = _db.Pacientes.ToList();
            ViewBag.pacientes = pacientes;

            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
            ViewBag.tratamientos = tratamientos;



            return View(boleta);
        }
        public ActionResult View(int id)

        {
            Boleta b = null;
            using (_db = new ClinicaContext())
            {
                b = _db.Boletas.Find(id);
                List<Odontologo> odontologos = _db.Odontologos.ToList();
                ViewBag.odontologos = odontologos;
            }
            return View(b);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Boleta b = _db.Boletas.Find(id);
            if (b == null)
            {
                return new HttpNotFoundResult();
            }
       
                List<Odontologo> odontologos = _db.Odontologos.ToList();
                ViewBag.odontologos = odontologos;


            List<Paciente> pacientes = _db.Pacientes.ToList();
            ViewBag.pacientes = pacientes;

            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
            ViewBag.tratamientos = tratamientos;
            return View(b);
            
        }

        [HttpPost]
        public ActionResult Edit(Boleta boleta)
        {
            if (ModelState.IsValid)
            {
                _db = new ClinicaContext();
                _db.Entry(boleta).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("View", "Boletas", new { id = 1 });
            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            List<Paciente> pacientes = _db.Pacientes.ToList();
            ViewBag.pacientes = pacientes;

            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
            ViewBag.tratamientos = tratamientos;

            return View(boleta);
        }
    }
}