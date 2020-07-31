using Clinica.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Clinica.Areas.Recepcionista.Controllers
{
    public class TratamientosController : Controller
    {
        private ClinicaContext _db = null;
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

            return View(tratamiento);
        }

        [HttpPost]
        public ActionResult Create(Tratamiento tratamiento)
        {
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

            return View(tratamiento);
        }
    }
}