using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Cita
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 9)]
        public String Rut { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Nombre { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Apellido { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Fecha { get; set; }


        [Required]
        public int IdOdontologo { get; set; }
        public virtual Odontologo Odontologo { get; set; }  // cambiar por la relacion
                                                            // guarda el ID en bd y no el nombre 

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Telefono { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Motivo { get; set; }


        public virtual ICollection<PacienteCita> RegistrosPC { get; set; }  // paciente cita
        public virtual ICollection<Odontologo> Odontologos { get; set; }

    }

}