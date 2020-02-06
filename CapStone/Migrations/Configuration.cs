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
                    Description = "Andrew Yang was born on Jan. 13, 1975 in Schenectady, New York. His parents emigrated from Taiwan in the 1960s. Yang grew up in Westchester County, New York. He enrolled at Brown University " +
                    "majoring in economics and political sciende. In 1996, Yang graduated from Brown and went on to attend Columbia Laaw School, earning his Juris Doctor in 1999. Yang is an author, entrepreneur, philanthopist, and lawyer." +
                    "In 2011, Yang was selected by 'The Obama Administration' as a 'Champion of Change' and as a 'Presidential Ambassador for Global Entrepreneurship' in 2015. Yang's focus largely on responding to the increasing " +
                    "development of automation. His main policy, 'Freedom Dividend', is a response to the growing automation with the concept of universal basic income of $1,000 a month to every American adult."
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
                    Party = "Independent/Democratic",
                    Description = "On September 8, 1941 Bernie Sanders was born to  Elias Ben Yehuda Sanders and  Dorothy Sanders, in Brooklyn, NY. From an early life, Sanders always were interested in politics." +
                    "He attended Brooklyn College then went on to graduate from the University of Chicago. He was an active protest organizer for the Congress of Racial Equality and the Student Nonviolent Coordination Committee." + 
                    "In 1981, Sanders was elected mayor of Burlington and was reelected three times after. He won House seat in 1990 representing Vermont's at-large congressional district, serving for 16 years before being elected U.S. Senator." +
                    "Sanders have been known for his opposition towards economic inequality. He has supported labor rights, universal and single-payer healthcare, paid parental leave, tuition-free tertiary education" +
                    ", and a program that would create jobs addressing climate change known as the Green New Deal. He supports reducing military spending in favor of pursuing more diplomatic and international cooperation," +
                    "putting more emphasis on labor rights and environmental concerns when negotiating trade deals."
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
                    Description = "Michael Bennet is an American businessman, lawyer, and polition serving as the U.S. Senator. Michael Bennet was born on Nov. 28, 1964 in New Dehli to Susanne Christine and Douglas J. Bennet; the latter " +
                    "serving as the U.S. ambassador of India. His grandfather was an economic adviser in Franklin D. Roosevelt's administration. Bennet earned his B.A. in history from Wesleyan University and continued to earn his J.D. from Yale Law School." +
                    ""
                },
                new Models.Candidate()
                {
                    Name = "Amy Jean Klobuchar",
                    Gender = "Female",
                    Occupation = "Senator",
                    Birthdate = "May 25, 1960",
                    BirthPlace = "Plythmouth, MN",
                    Hometown = "Plythmouth, MN",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "1",
                    Education = "JD, University of Chicago Law School\nBA, Yale University",
                    Party = "Democratic",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "Elizabeth Ann Warren",
                    Gender = "Female",
                    Occupation = "Senator",
                    Birthdate = "June 22, 1949",
                    BirthPlace = "Oklahoma City, OK",
                    Hometown = "Oklahoma City, OK",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "2",
                    Education = "JD, Rutgers Law School, 1996-1999\nBA, Brown University, 1992-1996",
                    Party = "Democratic",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "Tulsi Gabbard",
                    Gender = "Female",
                    Occupation = "U.S House of Representative member",
                    Birthdate = "April 12, 1981",
                    BirthPlace = "Leloaloa, American Samoa, US",
                    Hometown = "Hawaii",
                    Religion = "Hinduism",
                    MaritalStatus = "Married",
                    Children = "2",
                    Education = "BABS, Hawaii Pacific University",
                    Party = "Democratic",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "Joseph Robinette Biden Jr.",
                    Gender = "Male",
                    Occupation = "N/A",
                    Birthdate = "Nov. 20, 1942",
                    BirthPlace = "Scranton, PA",
                    Hometown = "Wilmington, DE",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "4",
                    Education = "JD, Syracuse University\nBA, University of Delaware",
                    Party = "Democratic/Independent",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "Deval Laurdine Patrick",
                    Gender = "Male",
                    Occupation = "Managing Director of Bain Capital",
                    Birthdate = "July 31, 1956",
                    BirthPlace = "Chicago, IL",
                    Hometown = "Schenectady, NY",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "2",
                    Education = "AB,JD, Harvard University",
                    Party = "Democratic",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "Michael Rubens Bloomberg",
                    Gender = "Male",
                    Occupation = "Owner of Bloomberg L.P.",
                    Birthdate = "Feb. 14, 1942",
                    BirthPlace = "Boston, MA",
                    Hometown = "Medford, MA",
                    Religion = "Jewish",
                    MaritalStatus = "Married",
                    Children = "2",
                    Education = "MBA, Harvard University\nBA, Johns Hopkins University",
                    Party = "Democratic",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "Peter Paul Montgomery Buttigieg",
                    Gender = "Male",
                    Occupation = "Mayor of South Bend",
                    Birthdate = "Jan. 19, 1982",
                    BirthPlace = "South Bend, IN",
                    Hometown = "South Bend, IN",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "N/A",
                    Education = "AB, Harvard University\nBA, Pembroke College, Oxford",
                    Party = "Democratic",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "Thomas Fahr Steyer",
                    Gender = "Male",
                    Occupation = "Mayor of South Bend",
                    Birthdate = "June 27, 1957",
                    BirthPlace = "New York, NY",
                    Hometown = "Upper East Side, NY",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "4",
                    Education = "MBA, Standford University\nBA, Yale University",
                    Party = "Democratic",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "Roque 'Rocky' De La Fuente",
                    Gender = "Male",
                    Occupation = "Businessman",
                    Birthdate = "Oct. 10, 1954",
                    BirthPlace = "San Diego, CA",
                    Hometown = "N/A",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "5",
                    Education = "BS, Instituto Patria National Autonomous University of Mexico",
                    Party = "Republican",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "William Floyd Weld",
                    Gender = "Male",
                    Occupation = "N/A",
                    Birthdate = "July. 31, 1945",
                    BirthPlace = "Smithtown, NY",
                    Hometown = "N/A",
                    Religion = "N/A",
                    MaritalStatus = "Married",
                    Children = "5",
                    Education = "JD,AB, Harvard University\nUniversity College, Oxford",
                    Party = "Republican",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "William Joesph Walsh",
                    Gender = "Male",
                    Occupation = "Conservative talk radio host",
                    Birthdate = "Dec. 27, 1961",
                    BirthPlace = "North Barrington, IL",
                    Hometown = "North Barrington, IL",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "5",
                    Education = "MPP, University of Chicago's Harris School of Public Policy Studies\nBA, University of Iowa",
                    Party = "Republican",
                    Description = ""
                },
                new Models.Candidate()
                {
                    Name = "Donald John Trump",
                    Gender = "Male",
                    Occupation = "P.O.T.U.S.",
                    Birthdate = "June 14, 1946",
                    BirthPlace = "Queens, New York City, NY",
                    Hometown = "Queens, New York City, NY",
                    Religion = "Christian",
                    MaritalStatus = "Married",
                    Children = "5",
                    Education = "BA, Wharton School, University of Pennsylvania",
                    Party = "Republican",
                    Description = ""
                }
            );
        }
    }
}
