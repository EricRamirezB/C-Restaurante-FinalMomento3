namespace Restaurante.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioImagen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menu", "ImagenM", c => c.String());
            AddColumn("dbo.Restauranteclase", "ImagenR", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restauranteclase", "ImagenR");
            DropColumn("dbo.Menu", "ImagenM");
        }
    }
}
