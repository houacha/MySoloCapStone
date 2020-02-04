namespace CapStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newpropsoncandidate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "Gender", c => c.String());
            AddColumn("dbo.Candidates", "Occupation", c => c.String());
            AddColumn("dbo.Candidates", "Birthdate", c => c.String());
            AddColumn("dbo.Candidates", "BirthPlace", c => c.String());
            AddColumn("dbo.Candidates", "Hometown", c => c.String());
            AddColumn("dbo.Candidates", "Religion", c => c.String());
            AddColumn("dbo.Candidates", "MaritalStatus", c => c.String());
            AddColumn("dbo.Candidates", "Children", c => c.String());
            AddColumn("dbo.Candidates", "Education", c => c.String());
            DropColumn("dbo.Candidates", "Bio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Candidates", "Bio", c => c.String());
            DropColumn("dbo.Candidates", "Education");
            DropColumn("dbo.Candidates", "Children");
            DropColumn("dbo.Candidates", "MaritalStatus");
            DropColumn("dbo.Candidates", "Religion");
            DropColumn("dbo.Candidates", "Hometown");
            DropColumn("dbo.Candidates", "BirthPlace");
            DropColumn("dbo.Candidates", "Birthdate");
            DropColumn("dbo.Candidates", "Occupation");
            DropColumn("dbo.Candidates", "Gender");
        }
    }
}
