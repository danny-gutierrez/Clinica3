namespace Clinica.Models
{
    public class PacienteCita
    {

        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int CitaId { get; set; }

        public virtual Paciente Paciente { get; set; }


        public virtual Cita Cita { get; set; }

    }
}