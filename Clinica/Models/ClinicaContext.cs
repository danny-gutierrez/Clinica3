using System.Data.Entity;

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
        public DbSet<BoletaPaciente> Registros { get; set; }

        public DbSet<PacienteTratamiento> RegistrosPT { get; set; }

        public DbSet<PacienteCita> RegistrosPC { get; set; }

        public DbSet<OdontologoCita> RegistrosCi { get; set; }
        public DbSet<OdontologoRemu> RegistrosRe { get; set; }




    }
}