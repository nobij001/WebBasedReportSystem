namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Regions", name: "Zone_Id", newName: "ZoneName_Id");
            RenameIndex(table: "dbo.Regions", name: "IX_Zone_Id", newName: "IX_ZoneName_Id");
            AddColumn("dbo.Zones", "ZoneName", c => c.String());
            AddColumn("dbo.Zones", "ZoneDirector", c => c.String());
            AddColumn("dbo.Zones", "ZoneGoal", c => c.String());
            AddColumn("dbo.Users", "ZoneId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "RegionId", c => c.Int(nullable: false));
            DropColumn("dbo.Zones", "Name");
            DropColumn("dbo.Zones", "Director");
            DropColumn("dbo.Zones", "Goal");
            DropColumn("dbo.Zones", "RegionName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zones", "RegionName", c => c.String());
            AddColumn("dbo.Zones", "Goal", c => c.String());
            AddColumn("dbo.Zones", "Director", c => c.String());
            AddColumn("dbo.Zones", "Name", c => c.String());
            DropColumn("dbo.Users", "RegionId");
            DropColumn("dbo.Users", "ZoneId");
            DropColumn("dbo.Zones", "ZoneGoal");
            DropColumn("dbo.Zones", "ZoneDirector");
            DropColumn("dbo.Zones", "ZoneName");
            RenameIndex(table: "dbo.Regions", name: "IX_ZoneName_Id", newName: "IX_Zone_Id");
            RenameColumn(table: "dbo.Regions", name: "ZoneName_Id", newName: "Zone_Id");
        }
    }
}
