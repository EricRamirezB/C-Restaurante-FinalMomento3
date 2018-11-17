namespace Restaurante.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorreccionNombre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restauranteclase", "HorarioR", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Restauranteclase", "HoratioR");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restauranteclase", "HoratioR", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Restauranteclase", "HorarioR");
        }
    }
}
