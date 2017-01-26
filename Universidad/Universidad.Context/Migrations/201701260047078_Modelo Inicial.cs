namespace Universidad.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Codigo = c.String(),
                        Apellidos = c.String(),
                        Nombres = c.String(),
                        GeneroId = c.Int(nullable: false),
                        EstadoCivilId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoId)
                .ForeignKey("dbo.EstadoCivils", t => t.EstadoCivilId, cascadeDelete: true)
                .ForeignKey("dbo.Generoes", t => t.GeneroId, cascadeDelete: true)
                .Index(t => t.GeneroId)
                .Index(t => t.EstadoCivilId);
            
            CreateTable(
                "dbo.EstadoCivils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Generoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumnoes", "GeneroId", "dbo.Generoes");
            DropForeignKey("dbo.Alumnoes", "EstadoCivilId", "dbo.EstadoCivils");
            DropIndex("dbo.Alumnoes", new[] { "EstadoCivilId" });
            DropIndex("dbo.Alumnoes", new[] { "GeneroId" });
            DropTable("dbo.Generoes");
            DropTable("dbo.EstadoCivils");
            DropTable("dbo.Alumnoes");
        }
    }
}
