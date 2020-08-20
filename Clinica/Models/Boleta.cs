﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Boleta

    {
        public int Id { get; set; }
        [Required]
      
        public int NB { get; set; }

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
        public int IdPaciente { get; set; }

        public virtual Paciente Paciente { get; set; }

        public int IdTratamiento { get; set; }

        public virtual Tratamiento Tratamiento { get; set; }

        [Required]
       
        public DateTime Fecha { get; set; }

        [Required]
       
        public int Fono { get; set; }


        [Required]
      
        public int Valor { get; set; }

        [StringLength(25, MinimumLength = 5)]
        public String Detalle { get; set; }

        public virtual ICollection<BoletaPaciente> Registros { get; set; }


        public virtual ICollection<Odontologo> Odontologos { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }

        public virtual ICollection<Tratamiento> Tratamientos { get; set; }
    }
}

    
