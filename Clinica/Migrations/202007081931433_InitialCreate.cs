namespace Clinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                    Edad = c.String(nullable: false, maxLength: 3),

                    Correo = c.String(nullable: false, maxLength: 100),
                    Direccion = c.String(nullable: false, maxLength: 25),

                    Telefono = c.String(nullable: false, maxLength: 12),
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
        }
    }
}
