namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rev8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Inactive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Inactive", c => c.Int(nullable: false));
        }
    }
}
