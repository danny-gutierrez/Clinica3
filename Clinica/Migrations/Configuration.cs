﻿namespace Clinica.Migrations
{
    using Clinica.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Clinica.Models.ClinicaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Clinica.Models.ClinicaContext context)
        {

            // Odontologos
            Odontologo o1 = new Odontologo()

            {   Id= 1,
                Nombres = "Dra.Pamela",
                Apellidos = "Cea",
                Telefonos = 123456789,
                Direcciones = "Chiguayante",
                Region = "VIII",
                Comuna = "Lota",
                Correos = "c@ejemplo.cl",
                Sueldo = 800000,
                Rut = "16037888-5",
                IdTratamiento = 1,
                FechaIngreso = DateTime.Now,
                Edad = 30,
              //  Especialidad = "Endodoncia"

            };

            Odontologo o2 = new Odontologo()

            {
                Id = 2,
                Nombres = "Dra. Jazmin",
                Apellidos = "Briones",
                Telefonos = 123456789,
                Direcciones = "Concepcion",
                Region = "VIII",
                Comuna = "Lota",
                Correos = "Jazmin@ejemplo.cl",
                Sueldo = 800000,
                Rut = "123456789",
                IdTratamiento = 1,
                FechaIngreso = DateTime.Now,
                Edad = 40,
          //      Especialidad = "Limpieza General"

            };

            Odontologo o3 = new Odontologo()

            {
                Id = 3,
                Nombres = "Dr.Maria",
                Apellidos = "Urrutia",
                Telefonos = 123456789,
                Direcciones = "Santiago",
                Region = "VIII",
                Comuna = "Lota",
                Correos = "Guillermo@ejemplo.cl",
                Sueldo = 800000,
                Rut = "123456789",
                IdTratamiento = 1,
                FechaIngreso = DateTime.Now,
                Edad = 40,
            //    Especialidad = "Limpieza General"

            };

            Odontologo o4 = new Odontologo()

            {
                Id = 4,
                Nombres = "Dra.Carolina",
                Apellidos = "Norambuena",
                Telefonos = 123456789,
                Direcciones = "Santiago",
                Region = "VIII",
                Comuna = "Lota",
                Correos = "Guillermo@ejemplo.cl",
                Sueldo = 800000,
                Rut = "123456789",
                IdTratamiento = 1,
                FechaIngreso = DateTime.Now,
                Edad = 40,
         //       Especialidad = "Limpieza General"

            };

            context.Odontologos.Add(o1);
            context.Odontologos.Add(o2);
            context.Odontologos.Add(o3);
            context.Odontologos.Add(o4);
            context.SaveChanges();



            // Tratamientos 



            Tratamiento t1 = new Tratamiento()
            {

                Nombres = "Endodoncia",
                Valor = 80000,
                IdOdontologo = 1,
                Codigos = 00001,
                Descripcion = "Tratamiento",
                Horarios = DateTime.Now,
                FechaCreacion = DateTime.Now


            };

            Tratamiento t2 = new Tratamiento()
            {

                Nombres = "Ortodoncia",
                Valor = 150000,
                IdOdontologo = 2,
                Codigos = 00003,
                Descripcion = "Tratamiento",
                Horarios = DateTime.Now,
                FechaCreacion = DateTime.Now


            };
            Tratamiento t3 = new Tratamiento()
            {

                Nombres = "Protesis",
                Valor = 50000,
                IdOdontologo = 3,
                Codigos = 00003,
                Descripcion = "Tratamiento",
                Horarios = DateTime.Now,
                FechaCreacion = DateTime.Now


            };
            Tratamiento t4 = new Tratamiento()
            {

                Nombres = "Limpieza ",
                Valor = 150000,
                IdOdontologo = 4,
                Codigos = 00003,
                Descripcion = "Tratamiento",
                Horarios = DateTime.Now,
                FechaCreacion = DateTime.Now


            };

            context.Tratamientos.Add(t1);
            context.Tratamientos.Add(t2);
            context.Tratamientos.Add(t3);
            context.Tratamientos.Add(t4);
            context.SaveChanges();



            // Pacientes
            Paciente p1 = new Paciente()
            {

                Nombre = "Danny",
                Apellido = "Gutierrez",
                Rut = "18.588.666-5",
                Edad = 28,
                Correo = "Danny@gmail.com",
                Region = "VIII",
                Comuna = "Lota",
                Direccion = "Alamos 203, Coronel",
                Telefono = 965855214


            };
            Paciente p2 = new Paciente()
            {

                Nombre = "Claudio",
                Apellido = "Quezada",
                Rut = "17.545.141-5",
                Edad = 29,
                Correo = "Claudio@gmail.com",
                Region = "VIII",
                Comuna = "Lota",
                Direccion = "Boldos 323, Coronel",
                Telefono = 412712413


            };
            Paciente p3 = new Paciente()
            {

                Nombre = "Fabian",
                Apellido = "Zenteno",
                Rut = "18.588.666-5",
                Edad = 28,
                Correo = "Fabian@gmail.com",
                Region = "VIII",
                Comuna = "Lota",
                Direccion = "Alamos 203, Coronel",
                Telefono = 965855214


            };
            Paciente p4 = new Paciente()
            {

                Nombre = "Juanito",
                Apellido = "Perez",
                Rut = "18.588.666-5",
                Edad = 28,
                Correo = "Juanito@gmail.com",
                Region = "VIII",
                Comuna = "Lota",
                Direccion = "Alamos 203, Coronel",
                Telefono = 965855214


            };
            context.Pacientes.Add(p1);
            context.Pacientes.Add(p2);
            context.Pacientes.Add(p3);
            context.Pacientes.Add(p4);
            context.SaveChanges();

            // Relacion Paciente Tratamiento

            PacienteTratamiento pt1 = new PacienteTratamiento()
            {

                PacienteId = p1.Id,
                TratamientoId = t1.Id


            };

            PacienteTratamiento pt2 = new PacienteTratamiento()
            {

                PacienteId = p1.Id,
                TratamientoId = t2.Id


            };
            PacienteTratamiento pt3 = new PacienteTratamiento()
            {

                PacienteId = p2.Id,
                TratamientoId = t2.Id


            };

            PacienteTratamiento pt4 = new PacienteTratamiento()
            {

                PacienteId = p3.Id,
                TratamientoId = t3.Id


            };

            PacienteTratamiento pt5 = new PacienteTratamiento()
            {

                PacienteId = p4.Id,
                TratamientoId = t3.Id


            };
            context.RegistrosPT.Add(pt1);
            context.RegistrosPT.Add(pt2);
            context.RegistrosPT.Add(pt3);
            context.RegistrosPT.Add(pt4);
            context.RegistrosPT.Add(pt5);
            context.SaveChanges();





            //Boletas
            Boleta b1 = new Boleta()
            {
                NB = 001,
                //Nombre = "Pedro",
                //Apellido = "Molina",
                IdOdontologo = 1,
                IdPaciente=1,
                IdTratamiento=1,
                Fecha = DateTime.Today,
                Fono = 985475575,
                Valor = 80000,
                Detalle = "Endodoncia"
            };
            Boleta b2 = new Boleta()
            {
                NB = 002,
                //Nombre = "Daniel",
                //Apellido = "Montes",
                IdOdontologo = 2,
                IdPaciente = 2,
                IdTratamiento = 2,
                Fecha = DateTime.Today,
                Fono = 925478547,
                Valor = 30000,
                Detalle = "Limpieza"
            };

            Boleta b3 = new Boleta()
            {
                NB = 003,
             //   Nombre = "Francisca",
               // Apellido = "Molina",
                IdOdontologo = 3,
                IdPaciente = 2,
                IdTratamiento = 1,
                Fecha = DateTime.Today,
                Fono = 985475575,
                Valor = 80000,
                Detalle = "Endodoncia"
            };
            Boleta b4 = new Boleta()
            {
                NB = 004,
                //Nombre = "Roberto",
                //Apellido = "Molina",
               IdOdontologo = 4,
                IdPaciente = 1,
                IdTratamiento = 2,
                Fecha = DateTime.Today,
                Fono = 985475575,
                Valor = 80000,
                Detalle = "Endodoncia"
            };

            context.Boletas.Add(b1);
            context.Boletas.Add(b2);
            context.Boletas.Add(b3);
            context.Boletas.Add(b4);
            context.SaveChanges();

            // Registro de enfermedad
            BoletaPaciente bp1 = new BoletaPaciente()
            {
                PacienteId = p1.Id,
                BoletaId = b1.Id,
            };
            BoletaPaciente bp2 = new BoletaPaciente()
            {
                PacienteId = p1.Id,
                BoletaId = b2.Id,
            };
            BoletaPaciente bp3 = new BoletaPaciente()
            {
                PacienteId = p2.Id,
                BoletaId = b2.Id,
            };
            context.Registros.Add(bp1);
            context.Registros.Add(bp2);
            context.Registros.Add(bp3);
            context.SaveChanges();


            //Citas
            Cita c1 = new Cita()
            {
               // Rut = "17.157.414-4",
                //Nombre = "Daniel",
                //Apellido = "Montes",
                IdPaciente = 1,
                IdTratamiento = 1,

               
                Fecha = DateTime.Now,
                IdOdontologo = 1,
                Telefono = 412712413,
                Motivo = "Limpieza",

            };
            Cita c2 = new Cita()
            {
              //  Rut = "12.345.678-1",
               // Nombre = "peters",
                //Apellido = "parras",
                IdPaciente = 2,
                IdTratamiento = 1,
                Fecha = DateTime.Now,
                IdOdontologo = 2,
                Telefono = 966585422,
                Motivo = "Endodoncia",

            };
            Cita c3 = new Cita()
            {
             //   Rut = "99.999.999-9",
               // Nombre = "Daniela",
                //Apellido = "Montes",
                IdPaciente = 3,
                IdTratamiento = 1,
                Fecha = DateTime.Now,
                IdOdontologo = 3,
                Telefono = 412712413,
                Motivo = "Limpieza",

            };
            Cita c4 = new Cita()
            {
             //   Rut = "55.555.555-5",
               // Nombre = "andrea",
                //Apellido = "Montes",
                IdPaciente = 4,
                IdTratamiento = 1,
                Fecha = DateTime.Now,
                IdOdontologo = 4,
                Telefono = 412712413,
                Motivo = "Limpieza",

            };
            context.Citas.Add(c1);
            context.Citas.Add(c2);
            context.Citas.Add(c3);
            context.Citas.Add(c4);
            context.SaveChanges();


            // Relacion paciente Citas

            PacienteCita pc1 = new PacienteCita()
            {
                PacienteId = p1.Id,
                CitaId = c1.Id


            };

            PacienteCita pc2 = new PacienteCita()
            {
                PacienteId = p1.Id,
                CitaId = c2.Id


            };
            PacienteCita pc3 = new PacienteCita()
            {
                PacienteId = p2.Id,
                CitaId = c2.Id


            };

            context.RegistrosPC.Add(pc1);

            context.RegistrosPC.Add(pc2);

            context.RegistrosPC.Add(pc3);
            context.SaveChanges();

            // Relacion odontologo citas
            OdontologoCita od1 = new OdontologoCita()
            {
                OdontologoId = o1.Id,
                CitaId = c1.Id
            };

            OdontologoCita od2 = new OdontologoCita()
            {
                OdontologoId = o1.Id,
                CitaId = c2.Id
            };

            OdontologoCita od3 = new OdontologoCita()
            {
                OdontologoId = o2.Id,
                CitaId = c2.Id
            };

            context.RegistrosCi.Add(od1);
            context.RegistrosCi.Add(od2);
            context.RegistrosCi.Add(od3);
            context.SaveChanges();

            //Remuneraciones
            Remuneracion r1 = new Remuneracion()
            {
               // Nombre = "Andrea",
               // Apellido = "Garcia",
                
                
                IdOdontologo = 1,
             
                Monto = 800000,
            };
            Remuneracion r2 = new Remuneracion()
            {
             //   Nombre = "Jazmin",
               // Apellido = "Ramirez",
                IdOdontologo = 2,
            
                Monto = 800000,
            };

            Remuneracion r3 = new Remuneracion()
            {
             //   Nombre = "Alejandro",
               // Apellido = "Ramirez",
                IdOdontologo = 3,
              
                Monto = 800000,
            };

            Remuneracion r4 = new Remuneracion()
            {
            //    Nombre = "Claudia",
              //  Apellido = "Ramirez",
                IdOdontologo = 4,
             
                Monto = 800000,
            };
            context.Remuneraciones.Add(r1);
            context.Remuneraciones.Add(r2);
            context.Remuneraciones.Add(r3);
            context.Remuneraciones.Add(r4);
            context.SaveChanges();

            //Relacion odontologo Remuneraciones
            OdontologoRemu odr = new OdontologoRemu()
            {
                OdontologoId = o1.Id,
                RemuneracionId = r1.Id
            };
            context.RegistrosRe.Add(odr);
            context.SaveChanges();

        }
    }
}
