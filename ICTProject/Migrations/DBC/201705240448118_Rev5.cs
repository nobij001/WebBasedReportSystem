namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rev5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyDatas",
                c => new
                    {
                        DailyDataId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        WorkingSDC = c.Int(nullable: false),
                        Appointments = c.Int(nullable: false),
                        Presentations = c.Int(nullable: false),
                        SuccessfulPresentations = c.Int(nullable: false),
                        Attendance = c.Int(nullable: false),
                        Members = c.Int(nullable: false),
                        NinthKyus = c.Int(nullable: false),
                        Classes = c.Int(nullable: false),
                        EquipmentSales = c.Single(nullable: false),
                        Interviews = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DailyDataId);
            
            CreateTable(
                "dbo.SdcDetails",
                c => new
                    {
                        SdcDetailsId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IsTeamCoordinator = c.Int(nullable: false),
                        IsFullTime = c.Int(nullable: false),
                        RegionId_RegionId = c.Int(),
                        ZoneId_ZoneId = c.Int(),
                    })
                .PrimaryKey(t => t.SdcDetailsId)
                .ForeignKey("dbo.Regions", t => t.RegionId_RegionId)
                .ForeignKey("dbo.Zones", t => t.ZoneId_ZoneId)
                .Index(t => t.RegionId_RegionId)
                .Index(t => t.ZoneId_ZoneId);
            
            CreateTable(
                "dbo.SdcNightlies",
                c => new
                    {
                        SdcNightlyId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.SdcNightlyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SdcDetails", "ZoneId_ZoneId", "dbo.Zones");
            DropForeignKey("dbo.SdcDetails", "RegionId_RegionId", "dbo.Regions");
            DropIndex("dbo.SdcDetails", new[] { "ZoneId_ZoneId" });
            DropIndex("dbo.SdcDetails", new[] { "RegionId_RegionId" });
            DropTable("dbo.SdcNightlies");
            DropTable("dbo.SdcDetails");
            DropTable("dbo.DailyDatas");
        }
    }
}
