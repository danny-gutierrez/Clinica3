using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class OdontologoRemu
    {
        public int Id { get; set; }

        public int OdontologoId { get; set; }

        public int RemuneracionId { get; set; }

        public virtual Odontologo Odontologo { get; set; }

        public virtual Remuneracion Remuneracion { get; set; }
    }
}