using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Odontologo
    {
        public int Id { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Nombres { get; set; }



        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Apellidos { get; set; }



        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Telefonos { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Direcciones { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Correos { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Rut { get; set; }

        [Required]
       

        public DateTime FechaIngreso { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Especialidad { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 1)]

        public String Edad { get; set; }

        public virtual ICollection<OdontologoCita> RegistrosCi { get; set; }
        public virtual ICollection<OdontologoRemu> RegistrosRe { get; set; }
        public virtual ICollection<Boleta>Boletas { get; set; }
        public virtual ICollection<Tratamiento> Tratamientos { get; set; }
        public virtual ICollection<Cita> Citas { get; set; }

    }
}