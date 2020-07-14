namespace Clinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PRUEBA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Pacientes",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Nombre = c.String(nullable: false, maxLength: 25),
                   Apellido = c.String(nullable: false, maxLength: 25),
                   Rut = c.String(nullable: false),
                   Edad = c.Int(nullable: false),
                   Correo = c.String(nullable: false, maxLength: 50),
                   Direccion = c.String(nullable: false, maxLength: 25),
                   Telefono = c.String(nullable: false, maxLength: 12),
               })
               .PrimaryKey(t => t.Id);
            CreateTable(
                "dbo.Boletas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NB = c.String(nullable: false, maxLength: 5),
                        Nombre = c.String(nullable: false, maxLength: 25),
                        Apellido = c.String(nullable: false, maxLength: 25),
                        Odontologo = c.String(nullable: false, maxLength: 25),
                        Fecha = c.String(nullable: false, maxLength: 25),
                        Fono = c.String(nullable: false, maxLength: 25),
                        Valor = c.String(nullable: false, maxLength: 25),
                        Detalle = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25),
                        Apellido = c.String(nullable: false, maxLength: 25),
                        Fecha = c.String(nullable: false, maxLength: 25),
                        Odontologo = c.String(nullable: false, maxLength: 25),
                        Telefono = c.String(nullable: false, maxLength: 25),
                        Motivo = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Odontologoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 25),
                        Apellidos = c.String(nullable: false, maxLength: 25),
                        Telefonos = c.String(nullable: false, maxLength: 25),
                        Direcciones = c.String(nullable: false, maxLength: 25),
                        Correos = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
           
            
            CreateTable(
                "dbo.Remuneracions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25),
                        Apellido = c.String(nullable: false, maxLength: 25),
                        Cargo = c.String(nullable: false, maxLength: 25),
                        Monto = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tratamientoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 25),
                        Valor = c.String(nullable: false, maxLength: 25),
                        Especialistas = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tratamientoes");
            DropTable("dbo.Remuneracions");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Odontologoes");
            DropTable("dbo.Citas");
            DropTable("dbo.Boletas");
        }
    }
}
