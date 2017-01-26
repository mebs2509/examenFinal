namespace Universidad.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SegundoModelo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Codigo = c.String(maxLength: 10),
                        Apellidos = c.String(maxLength: 50),
                        Nombres = c.String(maxLength: 50),
                        GeneroId = c.Int(nullable: false),
                        EstadoCivilId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoId)
                .ForeignKey("dbo.Estado Civil", t => t.EstadoCivilId, cascadeDelete: true)
                .ForeignKey("dbo.Genero", t => t.GeneroId, cascadeDelete: true)
                .Index(t => t.GeneroId)
                .Index(t => t.EstadoCivilId);
            
            CreateTable(
                "dbo.Estado Civil",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genero",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "GeneroId", "dbo.Genero");
            DropForeignKey("dbo.Alumno", "EstadoCivilId", "dbo.Estado Civil");
            DropIndex("dbo.Alumno", new[] { "EstadoCivilId" });
            DropIndex("dbo.Alumno", new[] { "GeneroId" });
            DropTable("dbo.Genero");
            DropTable("dbo.Estado Civil");
            DropTable("dbo.Alumno");
        }
    }
}
