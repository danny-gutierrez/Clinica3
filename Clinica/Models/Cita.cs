using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        [StringLength(25, MinimumLength = 5)]
        public String Odontologo { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Telefono { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Motivo { get; set; }

       
    }

}