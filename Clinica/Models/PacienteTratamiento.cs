namespace Clinica.Models
{
    public class PacienteTratamiento
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int TratamientoId { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Tratamiento Tratamiento { get; set; }
    }
}