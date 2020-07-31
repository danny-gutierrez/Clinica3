namespace Clinica.Models
{
    public class BoletaPaciente
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }

        public int BoletaId { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Boleta Boleta { get; set; }


    }
}