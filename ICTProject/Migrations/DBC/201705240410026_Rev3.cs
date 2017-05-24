namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rev3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Regions", "Zone_Id", "dbo.Zones");
            RenameColumn(table: "dbo.Regions", name: "Zone_Id", newName: "ZoneId_ZoneId");
            RenameIndex(table: "dbo.Regions", name: "IX_Zone_Id", newName: "IX_ZoneId_ZoneId");
            DropPrimaryKey("dbo.Regions");
            DropPrimaryKey("dbo.Zones");
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Regions", "Id");
            DropColumn("dbo.Zones", "Id");
            DropColumn("dbo.Users", "Id");
            DropColumn("dbo.Users", "ZoneId");
            DropColumn("dbo.Users", "RegionId");
            AddColumn("dbo.Regions", "RegionId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Zones", "ZoneId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Users", "UserId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Users", "RegionId_RegionId", c => c.Int());
            AddColumn("dbo.Users", "ZoneId_ZoneId", c => c.Int());
            AddPrimaryKey("dbo.Regions", "RegionId");
            AddPrimaryKey("dbo.Zones", "ZoneId");
            AddPrimaryKey("dbo.Users", "UserId");
            CreateIndex("dbo.Users", "RegionId_RegionId");
            CreateIndex("dbo.Users", "ZoneId_ZoneId");
            AddForeignKey("dbo.Users", "RegionId_RegionId", "dbo.Regions", "RegionId");
            AddForeignKey("dbo.Users", "ZoneId_ZoneId", "dbo.Zones", "ZoneId");
            AddForeignKey("dbo.Regions", "ZoneId_ZoneId", "dbo.Zones", "ZoneId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "RegionId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "ZoneId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Zones", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Regions", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Regions", "ZoneId_ZoneId", "dbo.Zones");
            DropForeignKey("dbo.Users", "ZoneId_ZoneId", "dbo.Zones");
            DropForeignKey("dbo.Users", "RegionId_RegionId", "dbo.Regions");
            DropIndex("dbo.Users", new[] { "ZoneId_ZoneId" });
            DropIndex("dbo.Users", new[] { "RegionId_RegionId" });
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Zones");
            DropPrimaryKey("dbo.Regions");
            DropColumn("dbo.Users", "ZoneId_ZoneId");
            DropColumn("dbo.Users", "RegionId_RegionId");
            DropColumn("dbo.Users", "UserId");
            DropColumn("dbo.Zones", "ZoneId");
            DropColumn("dbo.Regions", "RegionId");
            AddPrimaryKey("dbo.Users", "Id");
            AddPrimaryKey("dbo.Zones", "Id");
            AddPrimaryKey("dbo.Regions", "Id");
            RenameIndex(table: "dbo.Regions", name: "IX_ZoneId_ZoneId", newName: "IX_Zone_Id");
            RenameColumn(table: "dbo.Regions", name: "ZoneId_ZoneId", newName: "Zone_Id");
            AddForeignKey("dbo.Regions", "Zone_Id", "dbo.Zones", "Id");
        }
    }
}
