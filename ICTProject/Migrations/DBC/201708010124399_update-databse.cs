namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyDatas", "SdcDetailsID_SdcDetailsId", c => c.Int());
            CreateIndex("dbo.DailyDatas", "SdcDetailsID_SdcDetailsId");
            AddForeignKey("dbo.DailyDatas", "SdcDetailsID_SdcDetailsId", "dbo.SdcDetails", "SdcDetailsId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DailyDatas", "SdcDetailsID_SdcDetailsId", "dbo.SdcDetails");
            DropIndex("dbo.DailyDatas", new[] { "SdcDetailsID_SdcDetailsId" });
            DropColumn("dbo.DailyDatas", "SdcDetailsID_SdcDetailsId");
        }
    }
}
