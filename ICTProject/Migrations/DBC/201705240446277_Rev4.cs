namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rev4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Inactive", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Inactive");
        }
    }
}
