﻿using Clinica.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Clinica.Areas.Administrador.Controllers
{
    public class OdontologosController : Controller
    {
        // private ClinicaContext _db = null;
        // GET: Odontologos
        private ClinicaContext _db = new ClinicaContext();


        public ActionResult Historial(int id)
        {
            Odontologo odontologo = _db.Odontologos.Find(id);
            if (odontologo == null)
            {
                return new HttpNotFoundResult();

            }
            List<Cita> citas = _db.RegistrosCi
                              .Where(r => r.OdontologoId == id)
                              .Select(r => r.Cita)
                              .ToList();
            ViewBag.citas = citas;

            List<Remuneracion> remuneracion = _db.RegistrosRe
                              .Where(r => r.OdontologoId == id)
                              .Select(r => r.Remuneracion)
                              .ToList();
            ViewBag.remuneraciones = remuneracion;


            return View(odontologo);
        }






        public ActionResult Index()
        {
            IEnumerable<Odontologo> Odontologos = null;
            using (_db = new ClinicaContext())
            {
                Odontologos = _db.Odontologos.ToList();
            }
            return View(Odontologos);
        }

        //########################################################

        [HttpGet]
        public ActionResult Create()
        {
            Odontologo odontologo = new Odontologo();
            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
            ViewBag.tratamientos = tratamientos;

            return View(odontologo);


        }



        [HttpPost]
        public ActionResult Create(Odontologo odontologo)
        {
            if (ModelState.IsValid)
            {
                _db.Odontologos.Add(odontologo);
                _db.SaveChanges();
                //guarda en bd
                return RedirectToAction("Index", "Odontologos", new { id = 1 });
            }


            List<Tratamiento> tratamientos = _db.Tratamientos.ToList();
            ViewBag.tratamientos = tratamientos;
            return View(odontologo);
        }

        //#####################################################



        public ActionResult View(int id)
        {
            Odontologo odontologo = _db.Odontologos.Find(id);
            if (odontologo == null)
            {
                return new HttpNotFoundResult();

            }
            List<Cita> citas = _db.RegistrosCi
                              .Where(r => r.OdontologoId == id)
                              .Select(r => r.Cita)
                              .ToList();
            ViewBag.citas = citas;

            List<Remuneracion> remuneracion = _db.RegistrosRe
                              .Where(r => r.OdontologoId == id)
                              .Select(r => r.Remuneracion)
                              .ToList();
            ViewBag.remuneraciones = remuneracion;


            return View(odontologo);
        }





        [HttpGet]
        public ActionResult Edit(int id)
        {
            Odontologo o = _db.Odontologos.Find(id);
                if( o==null)
            {
                return new HttpNotFoundResult();
            }
            
            return View(o);
        }

        [HttpPost]
        public ActionResult Edit(Odontologo odontologo)
        {

            if (ModelState.IsValid)
            {
                _db = new ClinicaContext();
                _db.Entry(odontologo).State = EntityState.Modified;
                _db.SaveChanges();//guarda en bd
                return RedirectToAction("Index", "Odontologos", new { id = 1 });
            }

            return View(odontologo);


        }
    }
}