using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class ClinicaContext : DbContext

    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Boleta> Boletas { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Odontologo> Odontologos { get; set; }
        public DbSet<Remuneracion> Remuneraciones { get; set; }
        public DbSet<Tratamiento> Tratamientos { get; set; }


    }
}