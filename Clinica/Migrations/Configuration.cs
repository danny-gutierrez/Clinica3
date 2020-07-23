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
            
            
            
             // Pacientes
            Paciente p1 = new Paciente()
            {

                Nombre = "Pedro",
                Apellido = "Molina",
                Rut = "18.588.666-5",
                Edad = "28",
                Correo = "Pedro@gmail.com",
                Direccion = "Alamos 203, Coronel",
                Telefono = "965855214"


            };
            Paciente p2 = new Paciente()
            {

                Nombre = "Daniel",
                Apellido = "Montes",
                Rut = "17.545.141-5",
                Edad = "29",
                Correo = "Daniel@gmail.com",
                Direccion = "Boldos 323, Coronel",
                Telefono = "412712413"


            };
            context.Pacientes.Add(p1);
            context.Pacientes.Add(p2);
            context.SaveChanges();



            //Boletas
            Boleta b1 = new Boleta()
            {
                NB = "001",
                Nombre = "Pedro",
                Apellido = "Molina",
                Odontologo = "Dra. Torres",
                Fecha = "22-07-2020",
                Fono = "985475575",
                Valor = "80.000",
                Detalle = "Endodoncia"
            };
            Boleta b2 = new Boleta()
            {
                NB = "002",
                Nombre = "Daniel",
                Apellido = "Montes",
                Odontologo = "Dra. Jazmin",
                Fecha = "22-07-2020",
                Fono = "925478547",
                Valor = " 30.000",
                Detalle = "Limpieza"
            };
            context.Boletas.Add(b1);
            context.Boletas.Add(b2);
            context.SaveChanges();



            //Citas
            Cita c1 = new Cita()
            {
                Rut = "17.157.414-4",
                Nombre = "Daniel",
                Apellido = "Montes",
                Fecha = "22-07-2020",
                Odontologo = "Dr.Torres",
                Telefono = "412712413",
                Motivo = "Limpieza",
        
            };
            Cita c2 = new Cita()
            {
                Rut = "12.345.678-1",
                Nombre = "peters",
                Apellido = "parras",
                Fecha = "22-07-2020",
                Odontologo = "Dra. Jazmin",
                Telefono = "966585422",
                Motivo = "Endodoncia",

            };
            context.Citas.Add(c1);
            context.Citas.Add(c2);
            context.SaveChanges();



            //Remuneraciones
            Remuneracion r1 = new Remuneracion()
            {
                Nombre = "Gabriela",
                Apellido = "Torres",
                Cargo = "Odontologo",
                Monto = "800.000",
            };
            Remuneracion r2 = new Remuneracion()
            {
                Nombre = "Jazmin",
                Apellido = "Briones",
                Cargo = "Odontologo",
                Monto = "800.000",
            };
            context.Boletas.Add(b1);
            context.Boletas.Add(b2);
            context.SaveChanges();
   
        }
    }
}
