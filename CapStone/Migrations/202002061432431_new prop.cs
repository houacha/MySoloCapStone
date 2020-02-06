namespace CapStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "Polling", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Candidates", "Polling");
        }
    }
}
