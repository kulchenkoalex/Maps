namespace Maps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Longitude : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Longitude", c => c.Single(nullable: false));
            DropColumn("dbo.Events", "Lotitude");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Lotitude", c => c.Single(nullable: false));
            DropColumn("dbo.Events", "Longitude");
        }
    }
}
