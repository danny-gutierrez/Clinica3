using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Odontologo
    {
        public int Id { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 2)]
        public String Nombres { get; set; }



        [Required]
        [StringLength(25, MinimumLength = 2)]
        public String Apellidos { get; set; }



        [Required(ErrorMessage = "Por favor, introduzca su número de teléfono")]


        [Range(100000000, 999999999, ErrorMessage = "Teléfono debe contener 9 dígitos")]


        public long Telefonos { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public String Direcciones { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 1)]
        public String Region { get; set; }
        [Required]

        [StringLength(25, MinimumLength = 1)]
        public String Comuna { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [StringLength(50, ErrorMessage = "Longitud 50 maxima")]
        [DataType(DataType.EmailAddress)]
        public String Correos { get; set; }

        [Required(ErrorMessage = "Debe ingresar el Rut")]
       
     

        public String Rut { get; set; }

        [Required]
       

        public DateTime FechaIngreso { get; set; }



        //   [Required]
        // public String Especialidad { get; set; }

        [Required(ErrorMessage = "Ingrese su edad")]
        [Range(18, 100, ErrorMessage = "Debe ser mayor de Edad ")]


        public int Edad { get; set; }

       [Required]
        public int Sueldo { get; set; }

        public int IdTratamiento { get; set; }

        public virtual Tratamiento Tratamiento { get; set; }

        public virtual ICollection<OdontologoCita> RegistrosCi { get; set; }
        public virtual ICollection<OdontologoRemu> RegistrosRe { get; set; }
        public virtual ICollection<Boleta>Boletas { get; set; }
        public virtual ICollection<Tratamiento> Tratamientos { get; set; }
        public virtual ICollection<Cita> Citas { get; set; }

        public virtual ICollection<Remuneracion> Remuneraciones { get; set; }



    }
}