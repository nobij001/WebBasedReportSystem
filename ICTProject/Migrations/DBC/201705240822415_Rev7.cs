namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rev7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ConfirmPassword", c => c.String(nullable: false));
            AddColumn("dbo.Users", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "LastName", c => c.String(maxLength: 128));
            AlterColumn("dbo.Users", "FirstName", c => c.String(maxLength: 128));
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String(maxLength: 32));
            DropColumn("dbo.Users", "EmailAddress");
            DropColumn("dbo.Users", "ConfirmPassword");
        }
    }
}
