namespace Restaurante.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreM = c.String(nullable: false, maxLength: 50),
                        DescripcionM = c.String(nullable: false, maxLength: 50),
                        FechaPedidoM = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Restauranteclase",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreR = c.String(nullable: false, maxLength: 50),
                        DireccionR = c.String(nullable: false, maxLength: 50),
                        TelefonoR = c.String(nullable: false, maxLength: 50),
                        HoratioR = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restauranteclase");
            DropTable("dbo.Menu");
            DropTable("dbo.Login");
        }
    }
}
