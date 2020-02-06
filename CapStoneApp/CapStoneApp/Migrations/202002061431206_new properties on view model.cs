namespace CapStoneApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newpropertiesonviewmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "CandidateName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "CandidateName");
        }
    }
}
