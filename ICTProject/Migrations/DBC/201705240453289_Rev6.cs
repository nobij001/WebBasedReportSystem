namespace ICTProject.Migrations.DBC
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rev6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notices",
                c => new
                    {
                        NoticesId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Message = c.String(),
                        UserId_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.NoticesId)
                .ForeignKey("dbo.Users", t => t.UserId_UserId)
                .Index(t => t.UserId_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notices", "UserId_UserId", "dbo.Users");
            DropIndex("dbo.Notices", new[] { "UserId_UserId" });
            DropTable("dbo.Notices");
        }
    }
}
