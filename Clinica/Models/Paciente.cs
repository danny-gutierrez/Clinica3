using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Paciente

    {
        public int Id { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 2)]
        public String Nombre { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2)]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "Debe ingresar el Rut")]
 
        public String Rut { get; set; }

        [Required(ErrorMessage = "Ingrese su edad")]
        [Range(1, 100, ErrorMessage = "Debe ser una Edad Real")]
        public int Edad { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [StringLength(50, ErrorMessage = "Longitud 50 maxima")]
        [DataType(DataType.EmailAddress)]
        public String Correo { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 1)]
        public String Region { get; set; }
        [Required]

        [StringLength(25, MinimumLength = 1)]
        public String Comuna { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Direccion { get; set; }


        
        [Required(ErrorMessage = "Por favor, introduzca su número de teléfono")]
    
        
        [Range(100000000, 999999999, ErrorMessage = "Teléfono debe contener 9 dígitos")]
        public int Telefono { get; set; }
        

        public virtual ICollection<BoletaPaciente> Registros { get; set; }

        public virtual ICollection<PacienteTratamiento> RegistrosPT { get; set; }  // paciente tratamiento
        public virtual ICollection<PacienteCita> RegistrosPC { get; set; }

        public virtual ICollection<Boleta> boletas { get; set; }




    }
}