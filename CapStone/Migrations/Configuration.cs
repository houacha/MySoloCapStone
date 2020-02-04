namespace CapStone.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CapStone.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CapStone.Models.ApplicationDbContext context)
        {
            context.Candidates.AddOrUpdate(
                new Models.Candidate()
                {
                    Name = "Andrew Yang",
                    Gender = "Male",
                    Occupation = "Attorney, Entrepreneur",
                    Birthdate = "1975",
                    BirthPlace = "Schenectady, NY",
                    Hometown = "Schenectady, NY",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "2",
                    Education = "JD, Columbia University School of Law, 1996-1999\nBA, Brown University, 1992-1996",
                    Party = "Democratic",
                    Description = ""
                },
            new Models.Candidate()
            {
                Name = "Bernard 'Bernie' Sanders",
                Gender = "Male",
                Occupation = "Senator",
                Birthdate = "Sept. 8, 1941",
                BirthPlace = "Brooklyn, NY",
                Hometown = "Burlington, VT",
                Religion = "Jewish",
                MaritalStatus = "Married",
                Children = "4",
                Education = "Brooklyn College\nBA, University of Chicago",
                Party = "Independent",
                Description = "On September 8, 1941 Bernie Sanders was born to  Elias Ben Yehuda Sanders and  Dorothy Sanders, in Brooklyn, NY. From an early life, Sanders always were interested in politics." +
                ""
            },
                      new Models.Candidate()
                      {
                          Name = "Michael Farrand Bennet",
                          Gender = "Male",
                          Occupation = "Senetor",
                          Birthdate = "Nov. 8, 1964",
                          BirthPlace = "New Delhi, India",
                          Hometown = "Washington, D.C.",
                          Religion = "N/A",
                          MaritalStatus = "Married",
                          Children = "3",
                          Education = "JD, Yale Law School\nBA, Wesleyan University",
                          Party = "Democratic",
                          Description = ""
                      }

            );
        }
    }
}
