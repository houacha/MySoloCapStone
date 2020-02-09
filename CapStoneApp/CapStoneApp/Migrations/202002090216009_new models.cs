namespace CapStoneApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InboxMesseges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Messege = c.String(),
                        InboxId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Inboxes", t => t.InboxId, cascadeDelete: true)
                .Index(t => t.InboxId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InboxMesseges", "InboxId", "dbo.Inboxes");
            DropIndex("dbo.InboxMesseges", new[] { "InboxId" });
            DropTable("dbo.InboxMesseges");
        }
    }
}
