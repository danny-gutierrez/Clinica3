using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Nombres { get; set; }



        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Valor { get; set; }



        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Especialistas { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Codigos { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Horarios { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String FechaCreacion { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Descripcion { get; set; }
    }
}