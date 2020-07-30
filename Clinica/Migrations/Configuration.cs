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
            
            { Nombres = "Dra.Andrea",
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
                Nombres = "Dra. Jazmin",
                Apellidos = "Ramirez",
                Telefonos = "569123456789",
                Direcciones = "Santiago",
                Correos = "Guillermo@ejemplo.cl",
                Rut = "123456789",
                FechaIngreso = "19-07-2020",
                Edad = "40",
                Especialidad = "Limpieza General"

            };

            Odontologo o3 = new Odontologo()

            {
                Nombres = "Dr.Alejandro",
                Apellidos = "Ramirez",
                Telefonos = "569123456789",
                Direcciones = "Santiago",
                Correos = "Guillermo@ejemplo.cl",
                Rut = "123456789",
                FechaIngreso = "19-07-2020",
                Edad = "40",
                Especialidad = "Limpieza General"

            };

            Odontologo o4 = new Odontologo()

            {
                Nombres = "Dra.Claudia",
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
            context.Odontologos.Add(o3);
            context.Odontologos.Add(o4);
            context.SaveChanges();



            // Tratamientos 



            Tratamiento t1 = new Tratamiento()
            {

                Nombres = "Ndodoncia",
                Valor = "80.000",
                Especialistas = "Dra.Andrea",
                Codigos = "00001",
                Descripcion = "Tratamiento",
            Horarios=" L a M 10:00 - 15:00",
            FechaCreacion="17-07-2020"


            };

            Tratamiento t2 = new Tratamiento()
            {

                Nombres = "Ortodoncia",
                Valor = "150.000",
                Especialistas = "Dra.Claudia",
                Codigos = "00003",
                Descripcion = "Trtamiento",
                Horarios = " Lunes 10:00 A.m ",
                FechaCreacion = "19-07-2020"


            };
            Tratamiento t3 = new Tratamiento()
            {

                Nombres = "Protesis",
                Valor = "150.000",
                Especialistas = "Dr.Alejandro",
                Codigos = "00003",
                Descripcion = "Trtamiento",
                Horarios = " Lunes 10:00 A.m ",
                FechaCreacion = "19-07-2020"


            };
            Tratamiento t4 = new Tratamiento()
            {

                Nombres = "Limpieza ",
                Valor = "150.000",
                Especialistas = "Dra. Jazmin",
                Codigos = "00003",
                Descripcion = "Trtamiento",
                Horarios = " Lunes 10:00 A.m ",
                FechaCreacion = "19-07-2020"


            };

            context.Tratamientos.Add(t1);
            context.Tratamientos.Add(t2);
            context.Tratamientos.Add(t3);
            context.Tratamientos.Add(t4);
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
            Paciente p3 = new Paciente()
            {

                Nombre = "Florencia",
                Apellido = "Molina",
                Rut = "18.588.666-5",
                Edad = "28",
                Correo = "Pedro@gmail.com",
                Direccion = "Alamos 203, Coronel",
                Telefono = "965855214"


            };
            Paciente p4 = new Paciente()
            {

                Nombre = "Junior",
                Apellido = "Molina",
                Rut = "18.588.666-5",
                Edad = "28",
                Correo = "Pedro@gmail.com",
                Direccion = "Alamos 203, Coronel",
                Telefono = "965855214"


            };
            context.Pacientes.Add(p1);
            context.Pacientes.Add(p2);
            context.Pacientes.Add(p3);
            context.Pacientes.Add(p4);
            context.SaveChanges();

            // Relacion Paciente Tratamiento

            PacienteTratamiento pt1 = new PacienteTratamiento()
            {

                PacienteId =p1.Id,
                TratamientoId =t1.Id


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

            context.RegistrosPT.Add(pt1);
            context.RegistrosPT.Add(pt2);
            context.RegistrosPT.Add(pt3);
            context.SaveChanges();





            //Boletas
            Boleta b1 = new Boleta()
            {
                NB = "001",
                Nombre = "Pedro",
                Apellido = "Molina",
                Odontologo = "Dra.Andrea",
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

            Boleta b3 = new Boleta()
            {
                NB = "003",
                Nombre = "Francisca",
                Apellido = "Molina",
                Odontologo = "Dra.Andrea",
                Fecha = "22-07-2020",
                Fono = "985475575",
                Valor = "80.000",
                Detalle = "Endodoncia"
            };
            Boleta b4 = new Boleta()
            {
                NB = "004",
                Nombre = "Roberto",
                Apellido = "Molina",
                Odontologo = "Dra.Claudia",
                Fecha = "22-07-2020",
                Fono = "985475575",
                Valor = "80.000",
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
                Rut = "17.157.414-4",
                Nombre = "Daniel",
                Apellido = "Montes",
                Fecha = "22-07-2020",
                Odontologo = "Dra.Claudia",
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
            Cita c3 = new Cita()
            {
                Rut = "99.999.999-9",
                Nombre = "Daniela",
                Apellido = "Montes",
                Fecha = "22-07-2020",
                Odontologo = "Dr.Andrea",
                Telefono = "412712413",
                Motivo = "Limpieza",

            };
            Cita c4 = new Cita()
            {
                Rut = "55.555.555-5",
                Nombre = "andrea",
                Apellido = "Montes",
                Fecha = "22-07-2020",
                Odontologo = "Dra.Claudia",
                Telefono = "412712413",
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
                PacienteId =p1.Id,
                CitaId=c1.Id


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
                Nombre = "Andrea",
                Apellido = "Garcia",
                Cargo = "Odontologo",
                Monto = "800.000",
            };
            Remuneracion r2 = new Remuneracion()
            {
                Nombre = "Jazmin",
                Apellido = "Ramirez",
                Cargo = "Odontologo",
                Monto = "800.000",
            };

            Remuneracion r3 = new Remuneracion()
            {
                Nombre = "Alejandro",
                Apellido = "Ramirez",
                Cargo = "Odontologo",
                Monto = "800.000",
            };

            Remuneracion r4 = new Remuneracion()
            {
                Nombre = "Claudia",
                Apellido = "Ramirez",
                Cargo = "Odontologo",
                Monto = "800.000",
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
