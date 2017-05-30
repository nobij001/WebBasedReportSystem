namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rev9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RememberMe", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RememberMe");
        }
    }
}
