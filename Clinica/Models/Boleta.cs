using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Boleta

    {
        public int Id { get; set; }
        [Required]
        [StringLength(5, MinimumLength = 1)]
        public String NB { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
         public String Nombre { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
         public String Apellido { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Odontologo { get; set; }

         [Required]
        [StringLength(25, MinimumLength = 5)]
         public String Fecha { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Fono { get; set; }


         [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Valor { get; set; }

        [StringLength(25, MinimumLength = 5)]
        public String Detalle { get; set; }

       
    }
}