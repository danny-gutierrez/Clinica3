using Clinica.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Clinica.Areas.Administrador.Controllers
{
    public class RemuneracionesController : Controller

    {
        private ClinicaContext _db = new ClinicaContext();
        // GET: Remuneraciones

        public ActionResult Sueldo()
        {

            ClinicaContext _db = new ClinicaContext();
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;

         

            return View(_db.Odontologos.ToList());


            // aca la tabla para los sueldos

           
        }

        public ActionResult Index()
        {

            ClinicaContext _db = new ClinicaContext();

            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;


            //  IEnumerable<Remuneracion> remuneracions = null;
            //using (_db = new ClinicaContext())
            //{
            //  remuneracions = _db.Remuneraciones.ToList();
            //}
            return View(_db.Remuneraciones.ToList());
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
                _db.Remuneraciones.Add(remuneracion);

                _db.SaveChanges();

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
            //  Remuneracion r = null;
            //using (_db = new ClinicaContext())
            //{
            //  r = _db.Remuneraciones.Find(id);
            // }


            Remuneracion remuneracion = null;
            using (_db = new ClinicaContext())
            {
                remuneracion = _db.Remuneraciones.Find(id);
                List<Odontologo> odontologos = _db.Odontologos.ToList();
                ViewBag.odontologos = odontologos;
            }



            return View(remuneracion);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

           Remuneracion remuneracion = _db.Remuneraciones.Find(id);
            if (remuneracion == null)
            {
                return new HttpNotFoundResult();

            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            return View(remuneracion);


            //  Remuneracion r = null;
            //using (_db = new ClinicaContext())
            //{
            //  r = _db.Remuneraciones.Find(id);
            //List<Odontologo> odontologos = _db.Odontologos.ToList();
            //ViewBag.odontologos = odontologos;
            //}
         
        }

        [HttpPost]
        public ActionResult Edit(Remuneracion remuneracion)
        {
            if (ModelState.IsValid)
            {
                _db = new ClinicaContext();
                _db.Entry(remuneracion).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index", "Remuneraciones", new { id = 1 });



               

            }
            List<Odontologo> odontologos = _db.Odontologos.ToList();
            ViewBag.odontologos = odontologos;
            return View(remuneracion);

        }
    }
}