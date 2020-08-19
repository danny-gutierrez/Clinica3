using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Remuneracion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Apellido { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Cargo { get; set; }

        [Required]
        public int Monto { get; set; }

        public int IdOdontologo { get; set; }

        public virtual Odontologo Odontologo { get; set; }


        public virtual ICollection<Odontologo> Odontologos { get; set; }



    }
}