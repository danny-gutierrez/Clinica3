﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class PacienteTratamiento
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int TratamientoId { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Tratamiento Tratamiento { get; set; }
    }
}