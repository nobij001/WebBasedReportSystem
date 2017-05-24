namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rev2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Regions", name: "ZoneName_Id", newName: "Zone_Id");
            RenameIndex(table: "dbo.Regions", name: "IX_ZoneName_Id", newName: "IX_Zone_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Regions", name: "IX_Zone_Id", newName: "IX_ZoneName_Id");
            RenameColumn(table: "dbo.Regions", name: "Zone_Id", newName: "ZoneName_Id");
        }
    }
}
