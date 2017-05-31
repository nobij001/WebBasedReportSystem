namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rev10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Internationals",
                c => new
                    {
                        InternationalId = c.Int(nullable: false, identity: true),
                        Continent = c.String(),
                    })
                .PrimaryKey(t => t.InternationalId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionsId = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                        PositionLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PositionsId);
            
            CreateTable(
                "dbo.PDTopics",
                c => new
                    {
                        PDTopicsId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PDTopicsId);
            
            AddColumn("dbo.Notices", "RegionId_RegionId", c => c.Int());
            AddColumn("dbo.Users", "PositionId_PositionsId", c => c.Int());
            AddColumn("dbo.SdcDetails", "DateAdded", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Notices", "RegionId_RegionId");
            CreateIndex("dbo.Users", "PositionId_PositionsId");
            AddForeignKey("dbo.Notices", "RegionId_RegionId", "dbo.Regions", "RegionId");
            AddForeignKey("dbo.Users", "PositionId_PositionsId", "dbo.Positions", "PositionsId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "PositionId_PositionsId", "dbo.Positions");
            DropForeignKey("dbo.Notices", "RegionId_RegionId", "dbo.Regions");
            DropIndex("dbo.Users", new[] { "PositionId_PositionsId" });
            DropIndex("dbo.Notices", new[] { "RegionId_RegionId" });
            DropColumn("dbo.SdcDetails", "DateAdded");
            DropColumn("dbo.Users", "PositionId_PositionsId");
            DropColumn("dbo.Notices", "RegionId_RegionId");
            DropTable("dbo.PDTopics");
            DropTable("dbo.Positions");
            DropTable("dbo.Internationals");
        }
    }
}
