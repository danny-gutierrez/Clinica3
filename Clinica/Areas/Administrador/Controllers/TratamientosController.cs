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
            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
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

           
            if (ModelState.IsValid)
            {


                //guarda en bd
                return RedirectToAction("View", "Tratamientos", new { id = 1 });
                
                
            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;


            return View(tratamiento);

            
           
           

        }


        //########################################################




        public ActionResult View(int id)
        {
            Tratamiento tratamiento = _db.Tratamientos.Find(id);
             if (tratamiento==null)
            {

            }
            return View(tratamiento);
        }


        //###################################################

        [HttpGet]
        public ActionResult Edit(int id)
        {
         
            Tratamiento tratamiento= _db.Tratamientos.Find(id);
                if (tratamiento == null)
                    {
                        return new HttpNotFoundResult();

                    }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            return View(tratamiento);

           
        }

        [HttpPost]
        public ActionResult Edit(int id,Tratamiento tratamiento)
        {
            Tratamiento t= _db.Tratamientos.Find(id);
            if (t == null)
            {
                return new HttpNotFoundResult();
            }
            if(ModelState.IsValid)
            {
                return RedirectToAction("View", "Tratamientos", new { id = id });
            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            return View(tratamiento);
        }
    }
}