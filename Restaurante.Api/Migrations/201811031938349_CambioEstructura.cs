namespace Restaurante.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEstructura : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menu", "precio", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menu", "precio");
        }
    }
}
