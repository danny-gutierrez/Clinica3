namespace Clinica.Migrations
{
    using Clinica.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Clinica.Models.ClinicaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Clinica.Models.ClinicaContext context)
        {

            // Odontologos
            Odontologo o1  = new Odontologo() 
            
            { Nombres = "Andres" ,
            Apellidos="Garcia",
            Telefonos="569123456789",
            Direcciones="Chiguayanate",
            Correos="c@ejemplo.cl",
            Rut="16037888-5",
            FechaIngreso="17-07-2020",
            Edad="30",
            Especialidad="Endodoncia"
            
            };

            Odontologo o2 =new Odontologo()

            {
                Nombres = "Guillermo",
                Apellidos = "Ramirez",
                Telefonos = "569123456789",
                Direcciones = "Santiago",
                Correos = "Guillermo@ejemplo.cl",
                Rut = "123456789",
                FechaIngreso = "19-07-2020",
                Edad = "40",
                Especialidad = "Limpieza General"

            };

            context.Odontologos.Add(o1);
            context.Odontologos.Add(o2);
            context.SaveChanges();



            // Tratamientos 



            Tratamiento t1 = new Tratamiento()
            {

                Nombres = "Ndodoncia",
                Valor = "80.000",
                Especialistas = "JPErez",
                Codigos = "00001",
                Descripcion = "Tratamiento",
            Horarios=" L a M 10:00 - 15:00",
            FechaCreacion="17-07-2020"


            };

            Tratamiento t2 = new Tratamiento()
            {

                Nombres = "Ortodoncia",
                Valor = "150.000",
                Especialistas = "Cristian Perez",
                Codigos = "00003",
                Descripcion = "Trtamiento",
                Horarios = " Lunes 10:00 A.m ",
                FechaCreacion = "19-07-2020"


            };

            context.Tratamientos.Add(t1);
            context.Tratamientos.Add(t2);
            context.SaveChanges();

        }
    }
}
