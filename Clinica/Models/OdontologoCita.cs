using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class OdontologoCita
    {
        public int Id { get; set; }

        public int OdontologoId { get; set; }

        public int CitaId { get; set; }



        public virtual Odontologo Odontologo { get; set; }

        public virtual Cita Cita { get; set; }

        
    }
}