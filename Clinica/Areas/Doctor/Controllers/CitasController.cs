using Clinica.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;



namespace Clinica.Areas.Doctor.Controllers
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

            List<Paciente> pacientes = _db.Pacientes.ToList();
            ViewBag.pacientes = pacientes;

            return View(_db.Citas.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {



            Cita cita = new Cita();

            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            List<Paciente> pacientes = _db.Pacientes.ToList();
            ViewBag.pacientes = pacientes;

            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
            ViewBag.tratamientos = tratamientos;

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

            List<Paciente> pacientes = _db.Pacientes.ToList();
            ViewBag.pacientes = pacientes;

            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
            ViewBag.tratamientos = tratamientos;
            return View(cita);



        }
        public ActionResult View(int id)
        {
            Cita cita = null;
            using (_db = new ClinicaContext())
            {
                cita = _db.Citas.Find(id);
                List<Odontologo> odontologos = _db.Odontologos.ToList();
                ViewBag.odontologos = odontologos;


                List<Paciente> pacientes = _db.Pacientes.ToList();
                ViewBag.pacientes = pacientes;

                List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
                ViewBag.tratamientos = tratamientos;
            }
            return View(cita);
        }




        [HttpGet]
        public ActionResult Edit(int id)
        {

            Cita cita = _db.Citas.Find(id);
            if (cita == null)
            {
                return new HttpNotFoundResult();
            }


            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            List<Paciente> pacientes = _db.Pacientes.ToList();
            ViewBag.pacientes = pacientes;

            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
            ViewBag.tratamientos = tratamientos;


            return View(cita);


        }

       
        


    }
}