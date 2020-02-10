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
            //context.Candidates.AddOrUpdate(
            //    new Models.Candidate()
            //    {
            //        Name = "Andrew Yang",
            //        Gender = "Male",
            //        Occupation = "Attorney, Entrepreneur",
            //        Birthdate = "1975",
            //        BirthPlace = "Schenectady, NY",
            //        Hometown = "Schenectady, NY",
            //        Religion = "Christian",
            //        MaritalStatus = "Married",
            //        Children = "2",
            //        Education = "JD, Columbia University School of Law, 1996-1999\nBA, Brown University, 1992-1996",
            //        Party = "Democratic",
            //        Polling = 4,
            //        Description = "Andrew Yang was born on Jan. 13, 1975 in Schenectady, New York. His parents emigrated from Taiwan in the 1960s. Yang grew up in Westchester County, New York. He enrolled at Brown University " +
            //        "majoring in economics and political sciende. In 1996, Yang graduated from Brown and went on to attend Columbia Laaw School, earning his Juris Doctor in 1999. Yang is an author, entrepreneur, philanthopist, and lawyer." +
            //        "In 2011, Yang was selected by 'The Obama Administration' as a 'Champion of Change' and as a 'Presidential Ambassador for Global Entrepreneurship' in 2015. Yang's focus largely on responding to the increasing " +
            //        "development of automation. His main policy, 'Freedom Dividend', is a response to the growing automation with the concept of universal basic income of $1,000 a month to every American adult."
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Bernard 'Bernie' Sanders",
            //        Gender = "Male",
            //        Occupation = "Senator",
            //        Birthdate = "Sept. 8, 1941",
            //        BirthPlace = "Brooklyn, NY",
            //        Hometown = "Burlington, VT",
            //        Religion = "Jewish",
            //        MaritalStatus = "Married",
            //        Children = "4",
            //        Education = "Brooklyn College\nBA, University of Chicago",
            //        Party = "Independent/Democratic",
            //        Polling = 24,
            //        Description = "On September 8, 1941 Bernie Sanders was born to  Elias Ben Yehuda Sanders and  Dorothy Sanders, in Brooklyn, NY. From an early life, Sanders always were interested in politics." +
            //        "He attended Brooklyn College then went on to graduate from the University of Chicago. He was an active protest organizer for the Congress of Racial Equality and the Student Nonviolent Coordination Committee." +
            //        "In 1981, Sanders was elected mayor of Burlington and was reelected three times after. He won House seat in 1990 representing Vermont's at-large congressional district, serving for 16 years before being elected U.S. Senator." +
            //        "Sanders have been known for his opposition towards economic inequality. He has supported labor rights, universal and single-payer healthcare, paid parental leave, tuition-free tertiary education" +
            //        ", and a program that would create jobs addressing climate change known as the Green New Deal. He supports reducing military spending in favor of pursuing more diplomatic and international cooperation," +
            //        "putting more emphasis on labor rights and environmental concerns when negotiating trade deals."
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Michael Farrand Bennet",
            //        Gender = "Male",
            //        Occupation = "Senetor",
            //        Birthdate = "Nov. 8, 1964",
            //        BirthPlace = "New Delhi, India",
            //        Hometown = "Washington, D.C.",
            //        Religion = "N/A",
            //        MaritalStatus = "Married",
            //        Children = "3",
            //        Education = "JD, Yale Law School\nBA, Wesleyan University",
            //        Party = "Democratic",
            //        Polling = 1,
            //        Description = "Michael Bennet is an American businessman, lawyer, and polition serving as the U.S. Senator. Michael Bennet was born on Nov. 28, 1964 in New Dehli to Susanne Christine and Douglas J. Bennet; the latter " +
            //        "serving as the U.S. ambassador of India. His grandfather was an economic adviser in Franklin D. Roosevelt's administration. Bennet earned his B.A. in history from Wesleyan University and continued to earn his J.D. from Yale Law School." +
            //        ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Amy Jean Klobuchar",
            //        Gender = "Female",
            //        Occupation = "Senator",
            //        Birthdate = "May 25, 1960",
            //        BirthPlace = "Plythmouth, MN",
            //        Hometown = "Plythmouth, MN",
            //        Religion = "Christian",
            //        MaritalStatus = "Married",
            //        Children = "1",
            //        Polling = 5,
            //        Education = "JD, University of Chicago Law School\nBA, Yale University",
            //        Party = "Democratic",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Elizabeth Ann Warren",
            //        Gender = "Female",
            //        Occupation = "Senator",
            //        Birthdate = "June 22, 1949",
            //        BirthPlace = "Oklahoma City, OK",
            //        Hometown = "Oklahoma City, OK",
            //        Religion = "Christian",
            //        MaritalStatus = "Married",
            //        Children = "2",
            //        Polling = 14,
            //        Education = "JD, Rutgers Law School, 1996-1999\nBA, Brown University, 1992-1996",
            //        Party = "Democratic",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Tulsi Gabbard",
            //        Gender = "Female",
            //        Occupation = "U.S House of Representative member",
            //        Birthdate = "April 12, 1981",
            //        BirthPlace = "Leloaloa, American Samoa, US",
            //        Hometown = "Hawaii",
            //        Religion = "Hinduism",
            //        MaritalStatus = "Married",
            //        Children = "2",
            //        Polling = 1,
            //        Education = "BABS, Hawaii Pacific University",
            //        Party = "Democratic",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Joseph Robinette Biden Jr.",
            //        Gender = "Male",
            //        Occupation = "N/A",
            //        Birthdate = "Nov. 20, 1942",
            //        BirthPlace = "Scranton, PA",
            //        Hometown = "Wilmington, DE",
            //        Religion = "Christian",
            //        MaritalStatus = "Married",
            //        Children = "4",
            //        Polling = 27,
            //        Education = "JD, Syracuse University\nBA, University of Delaware",
            //        Party = "Democratic/Independent",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Deval Laurdine Patrick",
            //        Gender = "Male",
            //        Occupation = "Managing Director of Bain Capital",
            //        Birthdate = "July 31, 1956",
            //        BirthPlace = "Chicago, IL",
            //        Hometown = "Schenectady, NY",
            //        Religion = "Christian",
            //        MaritalStatus = "Married",
            //        Children = "2",
            //        Polling = 1,
            //        Education = "AB,JD, Harvard University",
            //        Party = "Democratic",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Michael Rubens Bloomberg",
            //        Gender = "Male",
            //        Occupation = "Owner of Bloomberg L.P.",
            //        Birthdate = "Feb. 14, 1942",
            //        BirthPlace = "Boston, MA",
            //        Hometown = "Medford, MA",
            //        Religion = "Jewish",
            //        MaritalStatus = "Married",
            //        Children = "2",
            //        Polling = 8,
            //        Education = "MBA, Harvard University\nBA, Johns Hopkins University",
            //        Party = "Democratic",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Peter Paul Montgomery Buttigieg",
            //        Gender = "Male",
            //        Occupation = "Mayor of South Bend",
            //        Birthdate = "Jan. 19, 1982",
            //        BirthPlace = "South Bend, IN",
            //        Hometown = "South Bend, IN",
            //        Religion = "Christian",
            //        MaritalStatus = "Married",
            //        Children = "N/A",
            //        Polling = 7,
            //        Education = "AB, Harvard University\nBA, Pembroke College, Oxford",
            //        Party = "Democratic",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Thomas Fahr Steyer",
            //        Gender = "Male",
            //        Occupation = "Mayor of South Bend",
            //        Birthdate = "June 27, 1957",
            //        BirthPlace = "New York, NY",
            //        Hometown = "Upper East Side, NY",
            //        Religion = "Christian",
            //        MaritalStatus = "Married",
            //        Children = "4",
            //        Polling = 2,
            //        Education = "MBA, Standford University\nBA, Yale University",
            //        Party = "Democratic",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Roque 'Rocky' De La Fuente",
            //        Gender = "Male",
            //        Occupation = "Businessman",
            //        Birthdate = "Oct. 10, 1954",
            //        BirthPlace = "San Diego, CA",
            //        Hometown = "N/A",
            //        Religion = "Christian",
            //        MaritalStatus = "Married",
            //        Children = "5",
            //        Polling = 0,
            //        Education = "BS, Instituto Patria National Autonomous University of Mexico",
            //        Party = "Republican",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "William Floyd Weld",
            //        Gender = "Male",
            //        Occupation = "N/A",
            //        Birthdate = "July. 31, 1945",
            //        BirthPlace = "Smithtown, NY",
            //        Hometown = "N/A",
            //        Religion = "N/A",
            //        MaritalStatus = "Married",
            //        Children = "5",
            //        Polling = 16,
            //        Education = "JD,AB, Harvard University\nUniversity College, Oxford",
            //        Party = "Republican",
            //        Description = ""
            //    },
            //    new Models.Candidate()
            //    {
            //        Name = "Donald John Trump",
            //        Gender = "Male",
            //        Occupation = "P.O.T.U.S.",
            //        Birthdate = "June 14, 1946",
            //        BirthPlace = "Queens, New York City, NY",
            //        Hometown = "Queens, New York City, NY",
            //        Religion = "Christian",
            //        MaritalStatus = "Married",
            //        Children = "5",
            //        Polling = 84,
            //        Education = "BA, Wharton School, University of Pennsylvania",
            //        Party = "Republican",
            //        Description = ""
            //    }
            //);
            //context.CampaignStaffs.AddOrUpdate(
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Zach Graumann",
            //        Position = "Campaign Manager",
            //        Experience = "Co-Founder/CEO of SuitUp Inc",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Randy Jones",
            //        Position = "Director of Political Affairs/Press Secretary",
            //        Experience = "Political Director of Peoples House Project",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Madalin Sammons",
            //        Position = "Communications Director",
            //        Experience = "Communications Director for Richard Ojeda's presidential campaign",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Zach Fang",
            //        Position = "National Organizing Director",
            //        Experience = "National Organizing Director for Tim Ryan's presidential campaign",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Faiz Shakir",
            //        Position = "Campaign Manager",
            //        Experience = "National political director of American Civil Liberties Union",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jeff Weaver",
            //        Position = "Senior Advisor",
            //        Experience = "Campaign manager of Bernie Sanders for President",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Chuck Rocha",
            //        Position = "Senoir Advisor",
            //        Experience = "Advisor of Bernie Sanders for President",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Analilia Mejia",
            //        Position = "Political Director",
            //        Experience = "Director of New Jersey Working Families Alliance",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Claire Sanberg",
            //        Position = "Organizing Director",
            //        Experience = "Deputy campaign manager for Abdul El-Sayed",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Becca Rast",
            //        Position = "National Field Director",
            //        Experience = "Campaign manager of Jess King for Congress",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Rene Spellman",
            //        Position = "Deputy Campaign Manager",
            //        Experience = "Executive of CAA Foundation",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Arianna Jones",
            //        Position = "Deputy Campaign Manager/Communications Director",
            //        Experience = "Senior vice president of PR for Revolution Messaging",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Ari Rabin-Havt",
            //        Position = "Deputy Campaign Manager/Chief of Staff",
            //        Experience = "Deputy chief of staff for Bernie Sanders",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Briahna Joy Gray",
            //        Position = "National Press Secretary",
            //        Experience = "Columnist and political editor of 'The Intercept'",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Daniel Barash",
            //        Position = "Senior Advisor",
            //        Experience = "Regional political director for expansion districts at the DCCD",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Craig Hughes",
            //        Position = "Senoir Advisor",
            //        Experience = "Partner at Hilltop Public Solutions",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jassica Boad",
            //        Position = "Naational Finance Director",
            //        Experience = "Western regional candidate fundraising director at DCCC",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jill Straus",
            //        Position = "Senior Advisor For Finance",
            //        Experience = "Founder at Straus/Baker",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Tracy Strurman",
            //        Position = "Senior Advisor for Finance",
            //        Experience = "Consultant at Golden State Strategies",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Shannon Beckham",
            //        Position = "Communications Advisor",
            //        Experience = "Communications advisor, office of Senator Michael Bennet",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Justin Buoen",
            //        Position = "Campaign Manager",
            //        Experience = "Partner, New Partners",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Pete Giangreco",
            //        Position = "Senior Advisor",
            //        Experience = "Partner, The Strategy Group",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Brigit Helgen",
            //        Position = "Senior Advisor",
            //        Experience = "Chief of staff for Amy Klobuchar",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Lucinda Ware",
            //        Position = "Political Director",
            //        Experience = "Vice president/partner SWAY",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Mike McLaughlin",
            //        Position = "Field Director",
            //        Experience = "Campaign manager for Harley Rouda for Congress",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Tim Hogan",
            //        Position = "Communications Director",
            //        Experience = "National press secretary, The Hub Project",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Carlie Waibel",
            //        Position = "National Press Secretary",
            //        Experience = "Senior spokesperson, Andrew Gillum for Governor of Florida",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Michael Schultz",
            //        Position = "National Finance Director",
            //        Experience = "Finance director, Ben Cardin for U.S. Senate",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Roger Lau",
            //        Position = "Campaign Manager",
            //        Experience = "Campaign Manager for Elizabeth Warren",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Tracey Lewis",
            //        Position = "Senior Advisor for Organizing",
            //        Experience = "Deputy executive director and COO at Democratic Senatorial Campaign Committee",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Hope Hall",
            //        Position = "Senior Advisor for Video and Senior Road Videographer",
            //        Experience = "Cinematographer, filmaker, photographer",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jon Donenberg",
            //        Position = "Senior Advisor and Policy Director",
            //        Experience = "Chief counsel and legislative director of Elizabeth Warren",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kaaren Hinck",
            //        Position = "Senior Advisor for Planning",
            //        Experience = "Scheduler for office of Senate, Sheldon Whitehouse",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Rebecca Pearcey",
            //        Position = "National Political Director",
            //        Experience = "Campaign manager, Ted Ctrickland for U.S. Senate",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kristen Orthman",
            //        Position = "Communications Director",
            //        Experience = "Senior political advisor to Elizabeth Warren",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Gabrielle Farrell",
            //        Position = "Press Secretary",
            //        Experience = "Director of communications for the NHDP",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Richard McDaniel",
            //        Position = "National Organizing Director",
            //        Experience = "Field/political director for Doug Jones for U.S. Senate",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Erin McCallum",
            //        Position = "Communications consultant",
            //        Experience = "N/A",
            //        CandidateId = 6
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Erika Tsuji",
            //        Position = "Spokeswoman",
            //        Experience = "N/A",
            //        CandidateId = 6
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Greg Schults",
            //        Position = "Campaign Manager",
            //        Experience = "Executive director, American Possibilities PAC",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kate Bedingfield",
            //        Position = "Deputy Campaign Manager and Communications Director",
            //        Experience = "Vice president of communications, Monumental Sports & Entertainment",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Symone Sanders",
            //        Position = "Senior Advisor",
            //        Experience = "Strategist and CNN political commentator",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Cristobal Alex",
            //        Position = "Senior Advisor",
            //        Experience = "President, Latino Victory Project",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Brandon English",
            //        Position = "Senior Advisor",
            //        Experience = "Senior advisor, GPS IMPACT",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Erin Wilson",
            //        Position = "Political Director",
            //        Experience = "State director for Senator Bob Casey",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kurt Bagley",
            //        Position = "National Organizing Director",
            //        Experience = "National field director, Democratic Congressional Campaign Committee",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jamal Brown",
            //        Position = "National Press Secretary",
            //        Experience = "Consultant, Civil Advisors",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "TJ Ducklo",
            //        Position = "National Press Secretary",
            //        Experience = "Senior communications director, NBC News",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Remi Yamamoto",
            //        Position = "Traveling National Press Secretary",
            //        Experience = "Communications director, Fred Hubbell for Governor of Iowa",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Katie Petrelius",
            //        Position = "National Finance Director",
            //        Experience = "Director of development, Biden Foundation",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kevin Sheekey",
            //        Position = "Campaign Manager",
            //        Experience = "Global head of communications, Bloomberg LP",
            //        CandidateId = 9
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Howard Wolfson",
            //        Position = "Senior Advisor",
            //        Experience = "Senior advisor, Bloomberg Philanthropies",
            //        CandidateId = 9
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jason Schecter",
            //        Position = "Communications Advisor",
            //        Experience = "Chief communications office, Bloomberg LP",
            //        CandidateId = 9
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Mike Schmuhl",
            //        Position = "Campaign Manager",
            //        Experience = "Consultant, Mel Hall for Congress",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Stephen Brokaw",
            //        Position = "National Political Director",
            //        Experience = "Marketing manager, Google",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Greta Carnes",
            //        Position = "National Organizing Director",
            //        Experience = "Texting director, Virginia Democratic Coordinated Campaign",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Lis Smith",
            //        Position = "Communications Director",
            //        Experience = "Deputy campaign manager, Martin O'Malley for President",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Chris Meagher",
            //        Position = "National Press Secretary",
            //        Experience = "Communications director, Montanans for Jon Tester",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Nina Smith",
            //        Position = "Traveling Press Secretary",
            //        Experience = "Managing partner/Co-owner/director of media relations at Megaphone Strategies",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Sonal Shah",
            //        Position = "Policy Director",
            //        Experience = "Executive director, Beeck Center for Social Impact and Innovation",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jess O'Connell",
            //        Position = "Senior Advisor",
            //        Experience = "CEO of Democratic National Committee",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Heather Hargreaves",
            //        Position = "Campaign Manager",
            //        Experience = "Executive director at NextGenAmerica",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Alberto Lammers",
            //        Position = "National Press Secretary",
            //        Experience = "Deputy director of communications, Need to Impeach",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Tawab Malekzad",
            //        Position = "Research Director",
            //        Experience = "Research director, Need to Impeach",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Cameron Koob",
            //        Position = "Delegate Operations and Ballet Access Manager",
            //        Experience = "Senior research associate, Need to Impeach",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Doug Rubin",
            //        Position = "Senior Advisor",
            //        Experience = "Founding partner, Northwind Strategies",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jerry Govan Jr.",
            //        Position = "Senior Advisor",
            //        Experience = "South Carolina State Representative",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jenna Narayanan",
            //        Position = "Senior Finance Advisor",
            //        Experience = "Former vice president, NextGenAmerica",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Arnie Sowell",
            //        Position = "Senior Policy Advisor",
            //        Experience = "Executive director, NextGen Policy Center",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Malik Hubbard",
            //        Position = "Political director",
            //        Experience = "National deputy African American vote director, Hilary Clinton for President",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Stuart Stevens",
            //        Position = "General Consultant",
            //        Experience = "Senior Advisor for Mitt Romney for President",
            //        CandidateId = 13
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Joe Hunter",
            //        Position = "Communications Director",
            //        Experience = "Communications director, Gary Johnson for President",
            //        CandidateId = 13
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Ieva Smidt",
            //        Position = "Finance Director",
            //        Experience = "Fundraising consultant",
            //        CandidateId = 13
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Brad Parscale",
            //        Position = "Campaign Manager",
            //        Experience = "Digital Director for Donald Trump for President",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Lara Trump",
            //        Position = "Senior Advisor",
            //        Experience = "Strategic planning and digital communications coordinator for Donald Trump's campaign committee",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Bob Paduchik",
            //        Position = "Senior Advisor",
            //        Experience = "Co-chair of Republican National Committee",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Katrina Pierson",
            //        Position = "Senior Advisor",
            //        Experience = "National spokeswoman, Donald Trump presidential campaign",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Bill Shine",
            //        Position = "Senior Advisor",
            //        Experience = "White House deputy of chief of staff for communications",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kimberly Guilfoyle",
            //        Position = "Senior Advisor",
            //        Experience = "Vice chairwoman, America First Action",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Chris Carr",
            //        Position = "Political Director",
            //        Experience = "Political director, Republican National Committee",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Tim Murtaugh",
            //        Position = "Director of Communications",
            //        Experience = "Director of Communications, U.S. Department of Agriculture",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kayleigh McEnany",
            //        Position = "National Press Secretary",
            //        Experience = "Spokesperson, Republican National Committee",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Cole Blocker",
            //        Position = "National Finance Director",
            //        Experience = "Deputy director, White House Visitor's Office",
            //        CandidateId = 14
            //    }
            //);
            //context.CampaignFinances.AddOrUpdate(
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 75.308239,
            //        Type = "Individual Contributions",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 204.187286,
            //        Type = "Total Receipts",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 109.763185,
            //        Type = "Total Disbursements",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 102.785704,
            //        Type = "Cash On Hand",
            //        CandidateId = 14
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 1.791341,
            //        Type = "Individual Contributions",
            //        CandidateId = 13
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 1.740043,
            //        Type = "Total Receipts",
            //        CandidateId = 13
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 1.703292,
            //        Type = "Total Disbursements",
            //        CandidateId = 13
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = .036753,
            //        Type = "Cash On Hand",
            //        CandidateId = 13
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = .016835,
            //        Type = "Individual Contributions",
            //        CandidateId = 12
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 13.891835,
            //        Type = "Total Receipts",
            //        CandidateId = 12
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 8.899614,
            //        Type = "Total Disbursements",
            //        CandidateId = 12
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 4.994564,
            //        Type = "Cash On Hand",
            //        CandidateId = 12
            //    }
            //);
        }
    }
}
