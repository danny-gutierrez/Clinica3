using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        
        public int IdOdontologo{ get; set; } 
        public virtual Odontologo Odontologo { get; set; }  // cambiar por la relacion
                                                            // guarda el ID en bd y no el nombre     
        

        [Required]
       
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Fono { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Valor { get; set; }

        [StringLength(25, MinimumLength = 5)]
        public String Detalle { get; set; }

        public virtual ICollection<BoletaPaciente> Registros { get; set; }


        public virtual ICollection<Odontologo> Odontologos { get; set; }
    }
}

    
