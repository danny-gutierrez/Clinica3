using Clinica.Models;
using Clinica.Models.ViewModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Clinica.Areas.Administrador.Controllers
{
    public class PacientesController : Controller
    {
        // private ClinicaContext _db = null;
        private ClinicaContext _db = new ClinicaContext();


        public ActionResult Historial(int id)
        {
            Paciente paciente = _db.Pacientes.Find(id);
            if (paciente == null)
            {
                return new HttpNotFoundResult();

            }
         
           


            List<Tratamiento> tratamientos = _db.RegistrosPT
                                             .Where(r => r.PacienteId == id)
                                               .Select(r => r.Tratamiento)
                                               .ToList();
            ViewBag.tratamientos = tratamientos;

            List<Boleta> boletas = _db.Registros
                                   .Where(r => r.PacienteId == id)
                                   .Select(r => r.Boleta)
                                   .ToList();
            ViewBag.boletas = boletas;

            List<Cita> citas = _db.RegistrosPC
                                           .Where(r => r.PacienteId == id)
                                             .Select(r => r.Cita)
                                             .ToList();
            ViewBag.citas = citas;


            return View(paciente);
        }



        public ActionResult Contador()
        {
            List<ContadorPaciente> contador = _db.Pacientes
                             .Select(p => new ContadorPaciente
                             {
                                 Paciente = p,
                                 Cantidad = p.RegistrosPT.Count()


                             })
                             .ToList();




            return View(contador);
        }


        public ActionResult ContadorPC()
        {
            List<ContadorPacienteCita> paciente = _db.Pacientes
                                            .Select(p => new ContadorPacienteCita
                                            {
                                                paciente = p,
                                                Cantidad = p.RegistrosPC.Count()



                                            }

                                            ).ToList();










            return View(paciente);
        }





        public ActionResult Index()
        {
            IEnumerable<Paciente> Pacientes = null;
            using (_db = new ClinicaContext())
            {
                Pacientes = _db.Pacientes.ToList();
            }
            return View(Pacientes);
        }

        [HttpGet]

        public ActionResult Create()
        {

            Paciente paciente = new Paciente();

            return View(paciente);
        }

        [HttpPost]
        public ActionResult Create(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _db.Pacientes.Add(paciente);
                _db.SaveChanges();


                return RedirectToAction("Index", "Pacientes", new { id = 1 });
            }

            return View(paciente);
        }

        public ActionResult View(int id)
        {
            Paciente paciente = _db.Pacientes.Find(id);
            if (paciente == null)
            {
                return new HttpNotFoundResult();

            }
            List<Boleta> boletas = _db.Registros
                                    .Where(r => r.PacienteId == id)
                                    .Select(r => r.Boleta)
                                    .ToList();
            ViewBag.boletas = boletas;


            List<Tratamiento> tratamientos = _db.RegistrosPT
                                             .Where(r => r.PacienteId == id)
                                               .Select(r => r.Tratamiento)
                                               .ToList();
            ViewBag.tratamientos = tratamientos;


            List<Cita> citas = _db.RegistrosPC
                                             .Where(r => r.PacienteId == id)
                                               .Select(r => r.Cita)
                                               .ToList();
            ViewBag.citas = citas;


            return View(paciente);
        }




        [HttpGet]
        public ActionResult Edit(int id)
        {
            Paciente p = _db.Pacientes.Find(id);
            if(p == null)
            {
                return new HttpNotFoundResult();
            }
            using (_db = new ClinicaContext())
           
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _db = new ClinicaContext();
                _db.Entry(paciente).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("View", "Pacientes", new { id = 1 });
            }
            return View(paciente);
        }
    }

}