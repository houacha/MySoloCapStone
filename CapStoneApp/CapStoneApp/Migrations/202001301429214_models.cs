namespace CapStoneApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contents", "ClientId", c => c.Int());
            AlterColumn("dbo.Fora", "ClientId", c => c.Int());
            CreateIndex("dbo.Contents", "ClientId");
            CreateIndex("dbo.Fora", "ClientId");
            AddForeignKey("dbo.Contents", "ClientId", "dbo.Clients", "Id");
            AddForeignKey("dbo.Fora", "ClientId", "dbo.Clients", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fora", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Contents", "ClientId", "dbo.Clients");
            DropIndex("dbo.Fora", new[] { "ClientId" });
            DropIndex("dbo.Contents", new[] { "ClientId" });
            AlterColumn("dbo.Fora", "ClientId", c => c.Int(nullable: false));
            AlterColumn("dbo.Contents", "ClientId", c => c.Int(nullable: false));
        }
    }
}
