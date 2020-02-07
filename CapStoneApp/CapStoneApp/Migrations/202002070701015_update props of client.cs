namespace CapStoneApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatepropsofclient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "DislikeId", c => c.Int());
            AlterColumn("dbo.Clients", "CandidateId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "CandidateId", c => c.Int(nullable: false));
            DropColumn("dbo.Clients", "DislikeId");
        }
    }
}
