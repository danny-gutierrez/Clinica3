using Clinica.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Clinica.Areas.Administrador.Controllers
{
    public class TratamientosController : Controller
    {
        private ClinicaContext _db = new ClinicaContext();
        // GET: Pacientes
        public ActionResult Index()

        {
            ClinicaContext _db = new ClinicaContext();
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            return View(_db.Tratamientos.ToList());
        }

        //#######################################

        [HttpGet]
        public ActionResult Create()

        {
            Tratamiento tratamiento = new Tratamiento();
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            return View(tratamiento);
        }

        [HttpPost]
        public ActionResult Create(Tratamiento tratamiento)
        {


            if (ModelState.IsValid)
            {
                _db.Tratamientos.Add(tratamiento);
               
                _db.SaveChanges();

                //guarda en bd
                return RedirectToAction("Index", "Tratamientos", new { id = 1 });


            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;


            return View(tratamiento);





        }


        //########################################################




        public ActionResult View(int id)
        {
            Tratamiento tratamiento = null;
            using(_db=new ClinicaContext())
            {
                tratamiento = _db.Tratamientos.Find(id);
                List<Odontologo> odontologos = _db.Odontologos.ToList();
                ViewBag.odontologos = odontologos;
            }
            
            return View(tratamiento);
        }


        //###################################################

        [HttpGet]
        public ActionResult Edit(int id)
        {

            Tratamiento tratamiento = _db.Tratamientos.Find(id);
            if (tratamiento == null)
            {
                return new HttpNotFoundResult();

            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            return View(tratamiento);


        }

        [HttpPost]
        public ActionResult Edit(int id, Tratamiento tratamiento)
        {
            if(ModelState.IsValid)
            {
                _db = new ClinicaContext();
                _db.Entry(tratamiento).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index", "Tratamientos", new { id = 1 });

            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            return View(tratamiento);
        }
    }
}