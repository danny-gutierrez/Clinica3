using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
    }
}