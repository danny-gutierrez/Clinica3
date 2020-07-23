using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Areas.Administrador.Controllers
{
    public class TratamientosController : Controller
    {
        private ClinicaContext _db = new ClinicaContext();
        // GET: Pacientes
        public ActionResult Index()
        {
            IEnumerable<Tratamiento> tratamientos = null;
            using (_db = new ClinicaContext())
            {
                tratamientos = _db.Tratamientos.ToList();
            }
            return View(tratamientos);
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

            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            if (ModelState.IsValid)
            {
                
                //guarda en bd
                return RedirectToAction("Index", "Tratamientos", new { id = 1 });
                
                
            }

            
            return View(tratamiento);

            
           
           

        }


        //########################################################




        public ActionResult View(int id)
        {
            Tratamiento t = null;
            using (_db = new ClinicaContext())
            {
                t = _db.Tratamientos.Find(id);
            }
            return View(t);
        }


        //###################################################

        [HttpGet]
        public ActionResult Edit(int id)
        {
         
            Tratamiento t = null;
            using (_db = new ClinicaContext())
            {
                t = _db.Tratamientos.Find(id);
                List<Odontologo> odontologos = _db.Odontologos.ToList();
                ViewBag.odontologos = odontologos;

            }
            
            return View(t);
           
        }

        [HttpPost]
        public ActionResult Edit(Tratamiento tratamiento)
        {
            if (ModelState.IsValid)
            {
               
                //guarda en bd
                return RedirectToAction("View", "Tratamientos", new { id = 1 });
                

            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

            return RedirectToAction("View", "Tratamientos", new { id = 1 });

        }
    }
}