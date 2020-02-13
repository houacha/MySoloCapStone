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
            //        Polling = 23.6,
            //        ImgPath = "/Content/sanders.jpg",
            //        Description = "On September 8, 1941 Bernie Sanders was born to  Elias Ben Yehuda Sanders and  Dorothy Sanders, in Brooklyn, NY. From an early life, Sanders always were interested in politics." +
            //        "He attended Brooklyn College then went on to graduate from the University of Chicago. He was an active protest organizer for the Congress of Racial Equality and the Student Nonviolent Coordination Committee." +
            //        "In 1981, Sanders was elected mayor of Burlington and was reelected three times after. He won House seat in 1990 representing Vermont's at-large congressional district, serving for 16 years before being elected U.S. Senator." +
            //        "Sanders have been known for his opposition towards economic inequality. He has supported labor rights, universal and single-payer healthcare, paid parental leave, tuition-free tertiary education" +
            //        ", and a program that would create jobs addressing climate change known as the Green New Deal. He supports reducing military spending in favor of pursuing more diplomatic and international cooperation," +
            //        "putting more emphasis on labor rights and environmental concerns when negotiating trade deals."
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
            //        Polling = 4.6,
            //        ImgPath = "/Content/amy.jpg",
            //        Education = "JD, University of Chicago Law School\nBA, Yale University",
            //        Party = "Democratic",
            //        Description = "Amy Klobuchar was born in Plythmouth, Minnesota to Rose and Jim Klobuchar. Her father was a columnist and her mother was a school teacher. Amy attended public schools in Plymouth and later went on to graduate from Yale University with a Bachelor of Arts in political science. While attending Yale, Klobuchar interned for then-Vice President Walter Mondale. After Yale, Amy continued her education at the University of Chicago Law School where she earned her Juris Doctor in 1985. She is serving as the current senator of Minnesota and is currently running for presidency."
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
            //        ImgPath = "/Content/warren.jpg",
            //        Polling = 12.4,
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
            //        Polling = 1.6,
            //        ImgPath = "/Content/tulsi.jpg",
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
            //        Polling = 19.2,
            //        ImgPath = "/Content/biden.jpg",
            //        Education = "JD, Syracuse University\nBA, University of Delaware",
            //        Party = "Democratic/Independent",
            //        Description = "Former Vice President, Joe Biden was born on Nov. 20 1942 in Scranton, Pennsylvania. Biden attended Archmere Academy in Claymont and later on went to attend and earn his bachelor's from the University of Delaware, with a double major in history and political science. From then on, he earned his Juris Doctor from Syracuse University College of Law. In 1972, Biden was elected Senator of Delaware and became the sixth-youngest senator in American history. In 2008, Biden became the running mate alongside former President Barack Obama. He is now currently running for presidency himself."
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
            //        ImgPath = "/Content/bloomberg.jpg",
            //        Polling = 14.2,
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
            //        Polling = 10.6,
            //        ImgPath = "/Content/Pete_Buttigieg.jpg",
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
            //        Polling = 1.8,
            //        ImgPath = "/Content/Tom_Steyer.jpg",
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
            //        ImgPath = "/Content/rocky.jpg",
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
            //        ImgPath = "/Content/Weld.jpg",
            //        Polling = 10,
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
            //        ImgPath = "/Content/trump.jpg",
            //        Polling = 90,
            //        Education = "BA, Wharton School, University of Pennsylvania",
            //        Party = "Republican",
            //        Description = "Trump was born in Queens, New York in 1946. He earned his bachelor's degree in economics from Wharton School in 1968 and went on to take charge of his family's real-estate business in 1971. He expanded the company into Brooklyn and Manhattan. He was the owner of both the Miss Universe and Miss USA pageants from 1996 to 2015 while also hosting the show The Apprentice. In 2016, Trump enter the presidential race and defeated 16 other candidates. He later went on to become the current sitting President. "
            //    }
            //);

            //context.CampaignStaffs.AddOrUpdate(
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Faiz Shakir",
            //        Position = "Campaign Manager",
            //        Experience = "National political director of American Civil Liberties Union",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jeff Weaver",
            //        Position = "Senior Advisor",
            //        Experience = "Campaign manager of Bernie Sanders for President",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Chuck Rocha",
            //        Position = "Senoir Advisor",
            //        Experience = "Advisor of Bernie Sanders for President",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Analilia Mejia",
            //        Position = "Political Director",
            //        Experience = "Director of New Jersey Working Families Alliance",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Claire Sanberg",
            //        Position = "Organizing Director",
            //        Experience = "Deputy campaign manager for Abdul El-Sayed",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Becca Rast",
            //        Position = "National Field Director",
            //        Experience = "Campaign manager of Jess King for Congress",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Rene Spellman",
            //        Position = "Deputy Campaign Manager",
            //        Experience = "Executive of CAA Foundation",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Arianna Jones",
            //        Position = "Deputy Campaign Manager/Communications Director",
            //        Experience = "Senior vice president of PR for Revolution Messaging",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Ari Rabin-Havt",
            //        Position = "Deputy Campaign Manager/Chief of Staff",
            //        Experience = "Deputy chief of staff for Bernie Sanders",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Briahna Joy Gray",
            //        Position = "National Press Secretary",
            //        Experience = "Columnist and political editor of 'The Intercept'",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Justin Buoen",
            //        Position = "Campaign Manager",
            //        Experience = "Partner, New Partners",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Pete Giangreco",
            //        Position = "Senior Advisor",
            //        Experience = "Partner, The Strategy Group",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Brigit Helgen",
            //        Position = "Senior Advisor",
            //        Experience = "Chief of staff for Amy Klobuchar",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Lucinda Ware",
            //        Position = "Political Director",
            //        Experience = "Vice president/partner SWAY",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Mike McLaughlin",
            //        Position = "Field Director",
            //        Experience = "Campaign manager for Harley Rouda for Congress",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Tim Hogan",
            //        Position = "Communications Director",
            //        Experience = "National press secretary, The Hub Project",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Carlie Waibel",
            //        Position = "National Press Secretary",
            //        Experience = "Senior spokesperson, Andrew Gillum for Governor of Florida",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Michael Schultz",
            //        Position = "National Finance Director",
            //        Experience = "Finance director, Ben Cardin for U.S. Senate",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Roger Lau",
            //        Position = "Campaign Manager",
            //        Experience = "Campaign Manager for Elizabeth Warren",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Tracey Lewis",
            //        Position = "Senior Advisor for Organizing",
            //        Experience = "Deputy executive director and COO at Democratic Senatorial Campaign Committee",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Hope Hall",
            //        Position = "Senior Advisor for Video and Senior Road Videographer",
            //        Experience = "Cinematographer, filmaker, photographer",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jon Donenberg",
            //        Position = "Senior Advisor and Policy Director",
            //        Experience = "Chief counsel and legislative director of Elizabeth Warren",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kaaren Hinck",
            //        Position = "Senior Advisor for Planning",
            //        Experience = "Scheduler for office of Senate, Sheldon Whitehouse",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Rebecca Pearcey",
            //        Position = "National Political Director",
            //        Experience = "Campaign manager, Ted Ctrickland for U.S. Senate",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kristen Orthman",
            //        Position = "Communications Director",
            //        Experience = "Senior political advisor to Elizabeth Warren",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Gabrielle Farrell",
            //        Position = "Press Secretary",
            //        Experience = "Director of communications for the NHDP",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Richard McDaniel",
            //        Position = "National Organizing Director",
            //        Experience = "Field/political director for Doug Jones for U.S. Senate",
            //        CandidateId = 3
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Erin McCallum",
            //        Position = "Communications consultant",
            //        Experience = "N/A",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Erika Tsuji",
            //        Position = "Spokeswoman",
            //        Experience = "N/A",
            //        CandidateId = 4
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Greg Schults",
            //        Position = "Campaign Manager",
            //        Experience = "Executive director, American Possibilities PAC",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kate Bedingfield",
            //        Position = "Deputy Campaign Manager and Communications Director",
            //        Experience = "Vice president of communications, Monumental Sports & Entertainment",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Symone Sanders",
            //        Position = "Senior Advisor",
            //        Experience = "Strategist and CNN political commentator",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Cristobal Alex",
            //        Position = "Senior Advisor",
            //        Experience = "President, Latino Victory Project",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Brandon English",
            //        Position = "Senior Advisor",
            //        Experience = "Senior advisor, GPS IMPACT",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Erin Wilson",
            //        Position = "Political Director",
            //        Experience = "State director for Senator Bob Casey",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kurt Bagley",
            //        Position = "National Organizing Director",
            //        Experience = "National field director, Democratic Congressional Campaign Committee",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jamal Brown",
            //        Position = "National Press Secretary",
            //        Experience = "Consultant, Civil Advisors",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "TJ Ducklo",
            //        Position = "National Press Secretary",
            //        Experience = "Senior communications director, NBC News",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Remi Yamamoto",
            //        Position = "Traveling National Press Secretary",
            //        Experience = "Communications director, Fred Hubbell for Governor of Iowa",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Katie Petrelius",
            //        Position = "National Finance Director",
            //        Experience = "Director of development, Biden Foundation",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kevin Sheekey",
            //        Position = "Campaign Manager",
            //        Experience = "Global head of communications, Bloomberg LP",
            //        CandidateId = 6
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Howard Wolfson",
            //        Position = "Senior Advisor",
            //        Experience = "Senior advisor, Bloomberg Philanthropies",
            //        CandidateId = 6
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jason Schecter",
            //        Position = "Communications Advisor",
            //        Experience = "Chief communications office, Bloomberg LP",
            //        CandidateId = 6
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Mike Schmuhl",
            //        Position = "Campaign Manager",
            //        Experience = "Consultant, Mel Hall for Congress",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Stephen Brokaw",
            //        Position = "National Political Director",
            //        Experience = "Marketing manager, Google",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Greta Carnes",
            //        Position = "National Organizing Director",
            //        Experience = "Texting director, Virginia Democratic Coordinated Campaign",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Lis Smith",
            //        Position = "Communications Director",
            //        Experience = "Deputy campaign manager, Martin O'Malley for President",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Chris Meagher",
            //        Position = "National Press Secretary",
            //        Experience = "Communications director, Montanans for Jon Tester",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Nina Smith",
            //        Position = "Traveling Press Secretary",
            //        Experience = "Managing partner/Co-owner/director of media relations at Megaphone Strategies",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Sonal Shah",
            //        Position = "Policy Director",
            //        Experience = "Executive director, Beeck Center for Social Impact and Innovation",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jess O'Connell",
            //        Position = "Senior Advisor",
            //        Experience = "CEO of Democratic National Committee",
            //        CandidateId = 7
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Heather Hargreaves",
            //        Position = "Campaign Manager",
            //        Experience = "Executive director at NextGenAmerica",
            //        CandidateId = 8
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Alberto Lammers",
            //        Position = "National Press Secretary",
            //        Experience = "Deputy director of communications, Need to Impeach",
            //        CandidateId = 8
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Tawab Malekzad",
            //        Position = "Research Director",
            //        Experience = "Research director, Need to Impeach",
            //        CandidateId = 8
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Cameron Koob",
            //        Position = "Delegate Operations and Ballet Access Manager",
            //        Experience = "Senior research associate, Need to Impeach",
            //        CandidateId = 8
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Doug Rubin",
            //        Position = "Senior Advisor",
            //        Experience = "Founding partner, Northwind Strategies",
            //        CandidateId = 8
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jerry Govan Jr.",
            //        Position = "Senior Advisor",
            //        Experience = "South Carolina State Representative",
            //        CandidateId = 8
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Jenna Narayanan",
            //        Position = "Senior Finance Advisor",
            //        Experience = "Former vice president, NextGenAmerica",
            //        CandidateId = 8
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Arnie Sowell",
            //        Position = "Senior Policy Advisor",
            //        Experience = "Executive director, NextGen Policy Center",
            //        CandidateId = 8
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Malik Hubbard",
            //        Position = "Political director",
            //        Experience = "National deputy African American vote director, Hilary Clinton for President",
            //        CandidateId = 8
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Stuart Stevens",
            //        Position = "General Consultant",
            //        Experience = "Senior Advisor for Mitt Romney for President",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Joe Hunter",
            //        Position = "Communications Director",
            //        Experience = "Communications director, Gary Johnson for President",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Ieva Smidt",
            //        Position = "Finance Director",
            //        Experience = "Fundraising consultant",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Brad Parscale",
            //        Position = "Campaign Manager",
            //        Experience = "Digital Director for Donald Trump for President",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Lara Trump",
            //        Position = "Senior Advisor",
            //        Experience = "Strategic planning and digital communications coordinator for Donald Trump's campaign committee",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Bob Paduchik",
            //        Position = "Senior Advisor",
            //        Experience = "Co-chair of Republican National Committee",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Katrina Pierson",
            //        Position = "Senior Advisor",
            //        Experience = "National spokeswoman, Donald Trump presidential campaign",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Bill Shine",
            //        Position = "Senior Advisor",
            //        Experience = "White House deputy of chief of staff for communications",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kimberly Guilfoyle",
            //        Position = "Senior Advisor",
            //        Experience = "Vice chairwoman, America First Action",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Chris Carr",
            //        Position = "Political Director",
            //        Experience = "Political director, Republican National Committee",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Tim Murtaugh",
            //        Position = "Director of Communications",
            //        Experience = "Director of Communications, U.S. Department of Agriculture",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Kayleigh McEnany",
            //        Position = "National Press Secretary",
            //        Experience = "Spokesperson, Republican National Committee",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignStaff()
            //    {
            //        Name = "Cole Blocker",
            //        Position = "National Finance Director",
            //        Experience = "Deputy director, White House Visitor's Office",
            //        CandidateId = 11
            //    }
            //);
            //context.CampaignFinances.AddOrUpdate(
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 75.308239,
            //        Type = "Individual Contributions",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 204.187286,
            //        Type = "Total Receipts",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 109.763185,
            //        Type = "Total Disbursements",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 102.785704,
            //        Type = "Cash On Hand",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 1.791341,
            //        Type = "Individual Contributions",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 1.740043,
            //        Type = "Total Receipts",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 1.703292,
            //        Type = "Total Disbursements",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = .036753,
            //        Type = "Cash On Hand",
            //        CandidateId = 10
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = .016835,
            //        Type = "Individual Contributions",
            //        CandidateId = 9
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 13.891835,
            //        Type = "Total Receipts",
            //        CandidateId = 9
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 8.899614,
            //        Type = "Total Disbursements",
            //        CandidateId = 9
            //    },
            //    new Models.CampaignFinance()
            //    {
            //        Amount = 4.994564,
            //        Type = "Cash On Hand",
            //        CandidateId = 9
            //    }
            //);
            //context.Policies.AddOrUpdate(
            //    new Models.Policy()
            //    {
            //        Issue = "Immigration",
            //        Stance = "Bernie Sanders supports creating a pathway to citizenship, providing legal status to DACA-eligible immigrants. He also wants to restructure the Immigration and Customs Enforcement agency.",
            //        CandidateId = 1
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Heathcare",
            //        Stance = "Sanders supports guaranteeing health care to all people as a right through single-payer program.",
            //        CandidateId = 1
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Environmental Issues",
            //        Stance = "Sanders has said that the climate crisis is the single greatest challenge facing our country and supports implementing the Green New Deal.",
            //        CandidateId = 1
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Trade",
            //        Stance = "Bernie wants to create trade policies that creates decent-paying jobs in America and ends the race to the bottom. According to his website, he believes that corporate America cannot continue to throw American workers out on the street while they outsource jobs.",
            //        CandidateId = 1
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Economy",
            //        Stance = "According to Bernie Sanders campaign website, Bernie states 'True individual freedom cannot exist without economic security.'",
            //        CandidateId = 1
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Education",
            //        Stance = "Bernie supports increasing funding for public education and opposes for-profit schools.",
            //        CandidateId = 1
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Gun Regulation",
            //        Stance = "Bernie supports expanding background checks, banning the sales of certain guns and prohibiting high-capacity ammo magazines.",
            //        CandidateId = 1
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Criminal Justice",
            //        Stance = "Bernie Sanders campaign website says, 'We are going to end the international embarrassment of having more people in jail than any other country on earth.Instead of spending $80 billion a year on jails and incarceration, we are going to invest in jobs and education for our young people.No more private prisons and detention centers.No more profiteering from locking people up. No more 'war on drugs.' No more keeping people in jail because they’re too poor to afford cash bail.' ",
            //        CandidateId = 1
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Foreign policy",
            //        Stance = "'The U.S. must lead the world in improving international cooperation in the fight against climate change, militarism, authoritarianism, and global inequality', according to Bernie's website. He wants to implement a foreign policy that focuses on democracy, human rights, diplomacy and peace, and economic fairness. Also allow Congress to reassert its Constitutional role in warmaking, so that no president can wage unauthorized and unconstitutional interventions overseas.",
            //        CandidateId = 1
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Immigration",
            //        Stance = "Amy Klobuchar believes in comprehensive immigration reform being crucial to moving our economy and country forward. She supports the DERAM act, border security and an accountable pathway to earned citizenship. She is commted to stopping the cruel and inhumane policy of the government taking kids away from their parents.",
            //        CandidateId = 2
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Heathcare",
            //        Stance = "Amy supports universal health care for all Americans and believes the quickest way to get there is through a public option that expands Medicare or Medicaid.",
            //        CandidateId = 2
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Environmental Issues",
            //        Stance = "According to her campaign, Amy intends to take aggressive executive actions to confront the climate crisis. In the first 100 days of her administration, she intends to get the U.S. back in the Paris International Climate Agreement, restore the Clean Power Plan, bring back the fuel-economy standards, introdue legistration that will put our country on the path to 100% net zero emissions by 2050, end the Trump Administration's cencoring of climate science, and reinstate the National Climate Assessment Advisory Committee.",
            //        CandidateId = 2
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Trade",
            //        Stance = "Klobuchar plans to restart the President's Export Council, which brings together business, labor, and agriculture leaders with Members of Congress to help promote a conprehensive export and trade strategy.",
            //        CandidateId = 2
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Economy",
            //        Stance = "Amy believes that to ensure all families have a fair shot in today's economy, she would invest in quality child care, overhaul the country's housing policy, raising minimun wage, provide paid family leave, support small business owners, and help Americans save for retirement.",
            //        CandidateId = 2
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Education",
            //        Stance = "To ensure that our children can get a great education, Klobuchar intends to increase teacher pay and funding for public schools. She supports allowing borrowers to refinance student loans at a lower rate, loan forgiveness for in-demand occupations, expended Pell grants, and tuition free one and two year community college degrees.",
            //        CandidateId = 2
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Gun Regulation",
            //        Stance = "Amy's campaign published a plan on gun violence that includes: universal background checks, banning bump stocks and high capacity magazines, and raising the age to buy military-style weapons from 18 to 21.",
            //        CandidateId = 2
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Criminal Justice",
            //        Stance = "Amy plans to create a clemency advisory board that advise the President from a criminal justice reform perspective.",
            //        CandidateId = 2
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Foreign policy",
            //        Stance = "Amy believes that we need to stand strong with our allies and that we must respect our frontline troops, diplomats and intelligence officers. She would invest in diplomacy and rebuild the State Department and modernize our military to stay one step ahead of China and Russia, which includes serious investments in cybersecurity.",
            //        CandidateId = 2
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Immigration",
            //        Stance = "Joe Biden's campaign website says he wants to pursue a 'humane immigration policy that upholds our values, strengthens our economy, and secures our border.'",
            //        CandidateId = 5
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Heathcare",
            //        Stance = "Joe Biden proposes protecting and building on the Affordable Care Act instead of switching to a Medicare for All system.",
            //        CandidateId = 5
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Environmental Issues",
            //        Stance = "Joe Biden says he 'will lead the world to address the climate emergency and lead through the power of example, by ensuring the U.S.achieves a 100 % clean energy economy and net - zero emissions no later than 2050.'",
            //        CandidateId = 5
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Trade",
            //        Stance = "Joe Biden's campaign website says, 'First and foremost, we must enforce existing trade laws and invest in the competitiveness of our workers and communities here at home, so that they compete on a level playing field.'",
            //        CandidateId = 5
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Economy",
            //        Stance = "Joe Biden's campaign website says, 'The American middle class built this country.Yet today, CEOs and Wall Street are putting profits over workers, plain and simple.It’s wrong. There used to be a basic bargain in this country that when you work hard, you were able to share in the prosperity your work helped create. It’s time to restore the dignity of work and give workers back the power to earn what they’re worth.'",
            //        CandidateId = 5
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Education",
            //        Stance = "Joe Biden's campaign website says he supports 'a plan that provides educators the support and respect they need and deserve, and invests in all children from birth, so that regardless of their zip code, parents’ income, race, or disability, they are prepared to succeed in tomorrow’s economy.'",
            //        CandidateId = 5
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Gun Regulation",
            //        Stance = "Joe Biden's campaign website says, 'As president, Biden will pursue constitutional, common - sense gun safety policies.Biden will: Hold gun manufacturers accountable.Ban the manufacture and sale of assault weapons and high - capacity magazines.Buy back the assault weapons and high - capacity magazines already in our communities.Reduce stockpiling of weapons.Require background checks for all gun sales.Create an effective program to ensure individuals who become prohibited from possessing firearms relinquish their weapons.Give states incentives to set up gun licensing programs.' ",
            //        CandidateId = 5
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Criminal Justice",
            //        Stance = "Joe Biden says he 'will strengthen America’s commitment to justice and reform our criminal justice system.'",
            //        CandidateId = 5
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Foreign policy",
            //        Stance = "Joe Biden says that the United States 'must lead not just with the example of power, but the power of our example.'",
            //        CandidateId = 5
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Immigration",
            //        Stance = "Donald Trump's campaign website says that 'President Trump enforced immigration laws to protect American communities and American jobs.President Trump protects American communities and restores law and order so Americans can feel safe in their communities.'",
            //        CandidateId = 11
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Heathcare",
            //        Stance = "Donald Trump's campaign website says that during his first term, Trump has worked on 'providing Americans the healthcare they need' and 'improving access to affordable, quality healthcare'. ",
            //        CandidateId = 11
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Environmental Issues",
            //        Stance = "Donald Trump's campaign website says that 'President Trump is reversing years of policies that locked - up American energy and restricted our ability to sell to other countries.Following the principles established by the President’s Executive Order on Energy Independence, EPA has proposed the repeal of the 'Clean Power Plan.' EPA Administrator Pruitt launched a task force to provide recommendations on how to streamline and improve the Superfund program, which is responsible for cleaning up land contaminated by hazardous waste.EPA has re - launched launched the Smart Sectors Program to partner with the private sector to achieve better environmental outcomes.'",
            //        CandidateId = 11
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Trade",
            //        Stance = "Donald Trump's campaign website says that, 'Since taking office, President Trump has advanced free, fair and reciprocal trade deals that protect American workers, ending decades of destructive trade policies.'",
            //        CandidateId = 11
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Economy",
            //        Stance = "Donald Trump's campaign website says that 'President Trump put the American economy into high gear, which created jobs and increased wealth.'",
            //        CandidateId = 11
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Education",
            //        Stance = "Donald Trump's campaign website says that 'President Donald J.Trump and his Administration have supported expanding school choice across the country so parents have a voice in their children’s education.President Trump and his Administration have identified and begun to end harmful regulations while maintaining protections for students.'",
            //        CandidateId = 11
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Gun Regulation",
            //        Stance = "Donald Trump's campaign website says that under his administration, 'Prosecutors were directed by the Department of Justice to focus on taking illegal guns off our streets. Criminals charged with unlawful possession of a firearm has increased 23 percent.'",
            //        CandidateId = 11
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Criminal Justice",
            //        Stance = "Donald Trump's campaign website says that 'President Donald J.Trump and the Department of Justice are working with local law enforcement to protect American communities.President Trump’s Administration is protecting the rights of all Americans.President Trump and the Department of Justice have aggressively confronted organized crime from street gangs to criminal cartels.'",
            //        CandidateId = 11
            //    },
            //    new Models.Policy()
            //    {
            //        Issue = "Foreign policy",
            //        Stance = "Donald Trump's campaign website says that 'President Trump put America first in trade so American workers aren’t put at a disadvantage.President Trump has used an America First foreign policy to restore respect for the United States throughout the world and to advance our interests.President Trump has made historic trips and delivered speeches abroad restoring America’s influence around the world.President Trump is rebuilding our military, defeating terrorist organizations, and confronting rogue nations to protect America and our allies.President Donald J.Trump announced additional measures to punish those who seek to undermine American democracy and security.'",
            //        CandidateId = 11
            //    }
            //);
            //context.CampaignThemes.AddOrUpdate(
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Economy",
            //        Stance = "President Trump jump-started America’s economy into record growth, which created jobs and increased take-home pay for working Americans.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Immigration",
            //        Stance = "President Trump protected the American homeland by enforcing immigration laws, so that every American can feel safe in their community.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Foreign Policy",
            //        Stance = "By promoting fair and reciprocal trade, President Trump put America first. This includes exiting TPP, renegotiating NAFTA, and securing major new bilateral deals with major trading partners.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "National Security",
            //        Stance = " President Trump rebuilt our military, crushed ISIS, and confronted rogue nations to protect America and our allies.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Regulation",
            //        Stance = "President Trump removed red tape and ended unnecessary regulations that stifle economic growth and prosperity.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Land and Agriculture",
            //        Stance = "President Trump created a task force on agriculture and rural prosperity that included actions to improve the lives of rural Americans",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Technology",
            //        Stance = "President Trump built stronger rural communities by ensuring Americans have access to the quality infrastructure they deserve.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Law and Justice",
            //        Stance = "President Trump partnered with local communities and worked with local law enforcement to protect American communities.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Veterans",
            //        Stance = "President Trump made sure the government fulfilled its commitment to our country’s veterans by reforming the V.A., including firing the 500 worst managers in the agency, and providing education and health benefits.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Environment",
            //        Stance = "President Trump reversed years of policies that locked up American energy and restricted our ability to sell to other countries.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Government Accountability",
            //        Stance = "One of President Trump’s biggest campaign promises was to make a government by and for the people. Throughout his first year in office, the President worked to drain the swamp and created more transparency.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Health Care",
            //        Stance = "President Trump repealed the Obamacare individual mandate, expanded plan choices and increased competition to bring down costs for consumers.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Social Programs",
            //        Stance = "President Trump and his Administration protected life by fighting back against illegal drug shipments, opioid abuse, and abortion service providers.",
            //        CandidateId = 11
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Immigration",
            //        Stance = "It’s no secret that our immigration system is broken, and for years, we have lacked the political will to fix it. We can secure our border and enforce our laws without tossing aside our values, our principles, and our humanity. Putting people in cages and tearing children away from their parents isn’t the answer. We have got to address the root causes of migration that push people to leave behind their homes and everything they know to undertake a dangerous journey for the chance at a better life, work that Vice President Biden led in the Obama-Biden Administration. At the same time, we must never forget that immigration is the reason the United States has been able to constantly renew and reinvent itself–legal immigration is an incredible source of strength for our country.",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Foreign Policy",
            //        Stance = "None of the great challenges we face can be met alone. If we don’t lead the world, someone else will. We must reaffirm and reform the alliances and institutions that, since World War II, have led the world to the greatest prosperity and security in history.",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Renewing American Values",
            //        Stance = "Inclusivity, tolerance, diversity, respect for the rule of law, freedom of speech, freedom of the press, freedom of religion—these values are the basis of our democracy and the source of our ability to lead the world in partnership with our allies. We must fight for our values here at home and wherever they are under attack. ",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Law and Justice",
            //        Stance = "We need to reform the criminal justice system to prioritize prevention, eliminate racial disparities at every stage, get rid of sentencing practices that don’t fit the crime, and help make sure formerly incarcerated individuals who have served their sentences are able to fully participate in our democracy and economy. We have to take action to reduce gun violence and hate crimes, strengthen the landmark Violence Against Women Act, and insist on real community policing that builds trust and makes every community safe. ",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Military",
            //        Stance = "Our military is one tool in our toolbox—along with diplomacy, economic power, education, science and technology. We must invest in and strengthen all elements of our power. And, we must modernize our military to prepare for the wars of tomorrow, while ensuring that we only deploy American troops into harm’s way when it is in our vital national security interest",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Environment",
            //        Stance = "Climate change threatens communities across the country, from beachfront coastal towns to rural farms in the heartland. We must turbocharge our efforts to address climate change and ensure that every American has access to clean drinking water, clean air, and an environment free from pollutants. ",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Protecting the right to vote",
            //        Stance = "Voting is the purest, most fundamental act of citizenship. Efforts to disenfranchise eligible voters are just as un-American now as they were during Jim Crow. We must strengthen our democracy by guaranteeing that every American’s vote is protected. We’ve got to make it easier—not harder—for Americans to exercise their right to vote, regardless of their zip code or the color of their skin, and make sure we count every voter’s voice equally. Finally, we must protect our voting booths and voter rolls from foreign powers who seek to undermine our democracy and interfere in our elections",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Economy",
            //        Stance = "Wealthy special interests, corporations, and foreign influences are skewing the policy process in Washington in their own favor by taking advantage of the way we finance elections. We need to create a public financing system for federal campaigns and pass a constitutional amendment to overturn Citizens United to amplify the voices of individual Americans and ensure elected officials are working for the people. In the meantime, the public has the right to know who is contributing to which advertisements and campaign initiatives.",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Health Care",
            //        Stance = "We should give every American the right to choose a public option like Medicare. We should also offer premium-free access to this public option for people who would otherwise qualify for Medicaid, but for the fact they have been denied access to it by governors and state legislatures who have refused the Affordable Care Act’s Medicaid expansion. We must ensure that they are receiving coverage that matches what they would have access to through Medicaid. And, we should dedicate the full force of our nation’s expertise and resources to tackle our greatest public health challenges, including cancer, Alzheimer’s, opioid addiction, and mental health.",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Education",
            //        Stance = "Education is at the heart of the American Dream, and essential for the United States to compete globally in the decades to come. Every American should have the opportunity throughout their lives to obtain the skills and education to realize their full potential—starting long before they enter kindergarten, and all the way through a certificate program, on-the-job training, community college, or a four-year degree. And everyone should have the opportunity to update their skills as rapidly as the economy changes.",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Retoring basic bargain for American Workers",
            //        Stance = "The American middle class built this country. Yet today, CEOs and Wall Street are putting profits over workers, plain and simple. It’s wrong. There used to be a basic bargain in this country that when you work hard, you were able to share in the prosperity your work helped create. It’s time to restore the dignity of work and give workers back the power to earn what they’re worth. ",
            //        CandidateId = 5
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Voting and Campaign Finance",
            //        Stance = "The right to vote is the bedrock of our democracy, and we must make sure people’s voices are heard. But today the right to vote is under attack. As President, Amy will champion a voting rights and democracy reform package, including automatically registering every 18-year-old in this country to vote, banning states from purging voters from rolls for not voting in recent elections, putting same-day registration policies in place, and restoring the Voting Rights Act. And it’s time to pass a constitutional amendment to overturn Citizens United and get dark money out of our politics, as well as establish a campaign finance system that increases the power of small donors through a matching system for small donations.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Criminal Justice",
            //        Stance = "Amy believes it is time for the Second Step Act. The First Step Act — which made key federal sentencing and prison reforms — only applied to those held in federal prisons and didn’t help the nearly 90 percent of incarcerated populations in state and local facilities. Amy will create federal incentives so that states can restore some discretion from mandatory sentencing for nonviolent offenders. She will also reform the cash bail system, expand funding for public defenders, eliminate obstacles to re-entering and participating fully in society, and fight for expanded drug courts. And during the first month of her presidency, Amy will create a clemency advisory board as well as a position in the White House — outside of the Department of Justice — that advises the President from a criminal justice reform perspective.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Foreign Policy",
            //        Stance = "Amy believes that we need to stand strong — and consistently — with our allies and that we must respect our frontline troops, diplomats and intelligence officers, who are out there every day risking their lives for our country, and deserve better than foreign policy by tweet. She would invest in diplomacy and rebuild the State Department and modernize our military to stay one step ahead of China and Russia, including with serious investments in cybersecurity",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Guns",
            //        Stance = "Gun violence prevention policies are long overdue. Amy supports a package of gun violence policies including instituting universal background checks by closing the gun show loophole and banning bump stocks, high capacity ammunition feeding devices and assault weapons. She is also the author of a proposal that would close what is commonly referred to as the ‘boyfriend loophole’ by preventing people who have abused dating partners from buying or owning firearms.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Climate",
            //        Stance = "Amy is deeply committed to tackling the climate crisis and believes that it is an urgent priority for our communities, for our economy and for our planet. She is a co-sponsor of a Green New Deal and has signed the No Fossil Fuel Money Pledge. On day one of Amy’s presidency she will get us back into the International Climate Change Agreement. On day two and day three, she will bring back the clean power rules and gas mileage standards that the Obama Administration put into place. And she will put forward sweeping legislation that provides a landmark investment in clean-energy jobs and infrastructure, provides incentives for tougher building codes, promotes rural renewable energy and development, and promotes “buy clean” policies.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Health Care",
            //        Stance = "Amy supports universal health care for all Americans, and she believes the quickest way to get there is through a public option that expands Medicare or Medicaid. She supports changes to the Affordable Care Act to help bring down costs to consumers including providing cost-sharing reductions, making it easier for states to put reinsurance in place, and continuing to implement delivery system reform. And she’s been fighting her whole life to bring down the cost of prescription drugs.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Prescription drugs",
            //        Stance = "When people are sick, their focus should be on getting better, rather than on how they can afford their prescriptions. Yet drug prices are an increasing burden across our country. Amy has been a champion when it comes to tackling the high costs of prescription drugs. She has authored proposals to lift the ban on Medicare negotiations for prescription drugs, allow personal importation of safe drugs from countries like Canada, and stop pharmaceutical companies from blocking less-expensive generics.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Mental Health",
            //        Stance = "Amy’s dad struggled with alcoholism and she saw the toll that mental health and substance use disorders can take on families and communities. As President, Amy will combat substance use disorder and prioritize mental health, including launching new prevention and early intervention initiatives, expanding access to treatment, and giving Americans a path to sustainable recovery. Her plan will ensure that everyone has the right — and the opportunity — to be pursued by grace and receive effective, professional treatment and help.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Reproductive Rights",
            //        Stance = "When it comes to women’s health, it’s clear that there is a concerted effort to attack, undermine and eliminate a woman’s right to make her own health care decisions. The recent bans in states are dangerous, they are unconstitutional, and they are out of step with the majority of Americans. Amy will continue working to protect the health and lives of women across the country. ",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Climate",
            //        Stance = "Amy is deeply committed to tackling the climate crisis and believes that it is an urgent priority for our communities, for our economy and for our planet. She is a co-sponsor of a Green New Deal and has signed the No Fossil Fuel Money Pledge. On day one of Amy’s presidency she will get us back into the International Climate Change Agreement. On day two and day three, she will bring back the clean power rules and gas mileage standards that the Obama Administration put into place. And she will put forward sweeping legislation that provides a landmark investment in clean-energy jobs and infrastructure, provides incentives for tougher building codes, promotes rural renewable energy and development, and promotes “buy clean” policies.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Prosperity",
            //        Stance = "Too many people aren’t sharing in our country’s economic prosperity. Shared prosperity is about ensuring all families have a fair shot in today’s economy, and Amy believes that this means investing in quality child care, overhauling our country’s housing policy, raising the minimum wage, providing paid family leave, supporting small business owners and entrepreneurs, as well as helping Americans save for retirement.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Education",
            //        Stance = "We also need to make sure all our children can get a great education. That means increasing teacher pay and funding for our public schools, with a focus on investment in areas that need it the most. And we need to make sure the rising costs of college aren’t a barrier to opportunity. Amy supports allowing borrowers to refinance student loans at lower rates, loan forgiveness for in-demand occupations, expanded Pell grants, and tuition-free one- and two-year community college degrees and technical certifications. ",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Economy",
            //        Stance = "Our laws and our policies have not kept pace with our changing economy and the digital revolution. Amy believes that this means we need to do more when it comes to taking on monopoly power and promoting competition, protecting consumers and their privacy in the digital age, and empowering workers with the tools they need to succeed in the evolving digital economy and preparing them for the jobs of tomorrow. ",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Infrastructure",
            //        Stance = "Amy has proposed a bold plan to rebuild America’s infrastructure, invest in our future, and create millions of good-paying American jobs. Her plan includes repairing and replacing our roads, highways and bridges as well as building smart climate infrastructure, ensuring clean water, modernizing our airports, seaports and inland waterways, expanding reliable public transit options, rebuilding our schools, overhauling our country’s housing policy, and connecting every household to the internet by 2022. ",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Immigration",
            //        Stance = "Comprehensive immigration reform is also crucial to moving our economy and our country forward.Amy supports a comprehensive immigration reform bill that includes the DREAM Act, border security and an accountable pathway to earned citizenship.She is committed to stopping the cruel and inhumane policy where the government is taking kids away from their parents.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Labor",
            //        Stance = "As the granddaughter of an iron ore miner and the daughter of a union teacher and a union newspaperman, Amy will bring one clear but simple guide to the White House: When unions are strong, our country is strong. As President, she’ll stand up against attempts to weaken our unions. That means achieving real labor law reform, ensuring free and fair union elections, protecting collective bargaining rights, rolling back Right to Work laws, and making it easier — and not harder — for workers to join unions",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Economic Justice",
            //        Stance = "We must beat back decades of systemic racism and inequality. Amy believes this begins with early-childcare and fixing our education system, addressing racism in health care such as disparities in maternal and infant mortality rates, ending housing discrimination so that everyone can afford to rent an apartment and own a home in a good neighborhood for their kids, and tackling disparities in wages and in retirement savings.",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Agriculture ",
            //        Stance = " America’s prosperity depends on supporting our family farmers and rural communities, but today farm income in America remains near historic lows. Amy has been an advocate for rural communities and our farmers, and she understands that this country has to do more to provide a strong safety net to help farmers, as well as invest in our rural communities, which includes hospitals, childcare, housing, connecting every household to high-speed internet by 2022, and a strong farm policy. ",
            //        CandidateId = 2
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Restore Democracy",
            //        Stance = "Restore the Voting Rights Act. Secure automatic voter registration for every American over 18. Overturn Citizens United. End racist voter suppression and partisan gerrymandering. Abolish burdensome voter ID laws. Re-enfranchise the more than 6 million Americans who have had their right to vote taken away by a felony conviction, paid their debt to society, and deserve to have their rights restored. Make Election Day a national holiday. Abolish super PACs. Replace corporate funding and donations from millionaires and billionaires with public funding of elections that amplifies small-dollar donations.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Reinvest in Public Education",
            //        Stance = "We must make sure that charter schools are accountable, transparent and truly serve the needs of disadvantaged children, not Wall Street, billionaire investors, and other private interests. We must ensure that a handful of billionaires don’t determine education policy for our nation’s children. We will oppose the DeVos-style privatization of our nation’s schools and will not allow public resources to be drained from public schools. We must guarantee childcare and universal pre-Kindergarten for every child in America to help level the playing field, create new and good jobs, and enable parents more easily balance the demands of work and home. We must increase pay for public school teachers so that their salary is commensurate with their importance to society. And we must invest in high-quality, ongoing professional development, and cancel teachers’ student debt.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Protecting the right to vote",
            //        Stance = "Voting is the purest, most fundamental act of citizenship. Efforts to disenfranchise eligible voters are just as un-American now as they were during Jim Crow. We must strengthen our democracy by guaranteeing that every American’s vote is protected. We’ve got to make it easier—not harder—for Americans to exercise their right to vote, regardless of their zip code or the color of their skin, and make sure we count every voter’s voice equally. Finally, we must protect our voting booths and voter rolls from foreign powers who seek to undermine our democracy and interfere in our elections",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Fight For Fair Trade",
            //        Stance = "Eliminate the incentives baked into our current trade and tax agreements that make it easier for multinational corporations to ship jobs overseas. Corporations should not be able to get a tax deduction for the expenses involved in moving their factories abroad and throwing American workers out on the street. Instead of providing federal tax breaks, contracts, grants, and loans to corporations that outsource jobs, we need to support the small businesses that are creating good jobs in America.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Invest In Rural America",
            //        Stance = "In addition to raising the minimum wage, making public college tuition-free, investing in infrastructure, and guaranteeing health care, we must do the following to protect and support our rural communities: Strengthen and expand enforcement of antitrust laws against agribusiness monopolies, so that food producers have a fairer share of market power to negotiate better prices and pay for their hard work.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Wall Street Reform",
            //        Stance = "Break up too-big-to-fail banks. End the too-big-to-jail doctrine. Reinstate the Glass-Steagall Act. Cap credit card interest rates. Allow every post office to offer basic and affordable banking services. Cap ATM fees. Audit the Federal Reserve and make it a more democratic institution so that it becomes responsive to the needs of ordinary Americans, not just the billionaires on Wall Street. Restrict rapid-fire financial speculation with a financial transactions tax. Reform credit rating agencies.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Empower Tribal Nations",
            //        Stance = "Stand with Native Americans in the struggle to protect their treaty and sovereign rights, advance traditional ways of life, and improve the quality of life for Native Americans by upholding the trust responsibility. Honor Native American tribal treaty rights and sovereignty, moving away from a relationship of paternalism and control toward one of deference and support. Reauthorize and expand the Violence Against Women Act to provide critical resources to women in Indian country and allow all tribes to prosecute non-Native criminals.",
            //        CandidateId = 1
            //    },

            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Immigration",
            //        Stance = "Enact comprehensive immigration reform, including a path towards citizenship. Expand DACA and DAPA, including providing immediate legal status for young people eligible for the DACA program and developing a humane policy for those seeking asylum. Completely reshape and reform our immigration enforcement system, including fundamentally restructuring ICE, an agency Senator Sanders voted against creating. End the barbaric practice of family separation and detention of children in cages. Dismantle cruel and inhumane deportation programs and detention centers. Establish standards for independent oversight of relevant agencies within DHS. Donald Trump has made himself the biggest platform of hate in the country, and he’s used the demonization of immigrants as his own personal political strategy. That must end, now.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Voting Rights",
            //        Stance = "Restore the Voting Rights Act. Re-enfranchise the right to vote to the 1 in 13 African-Americans who have had their vote taken away by a felony conviction, paid their debt to society, and deserve to have their rights restored. Secure automatic voter registration for every American over 18. End voter suppression and gerrymandering. Abolish burdensome voter ID laws. Make Election Day a national holiday.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Racial Justice",
            //        Stance = "In order to transform this country into a nation that affirms the value of its people of color, we must address the five central types of violence waged against black, brown and indigenous Americans: physical, political, legal, economic and environmental.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Criminal Justice",
            //        Stance = "End, once and for all, the destructive 'war on drugs,' including legalizing marijuana. Eliminate private prisons and detention centers. End cash bail. Abolish the death penalty. End all mandatory minimums and reinstate the federal system of parole. Seriously reform civil asset forfeitures. Bring about major police department reform. Prevent employers from discriminating against applicants based on criminal history by 'banning the box.'",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Gun Safety",
            //        Stance = "Take on the NRA and its corrupting effect on Washington. The NRA has become a partisan lobbying public-relations entity for gun manufacturers, and its influence must be stopped. Expand background checks. End the gun show loophole. All gun purchases should be subject to the same background check standards. Ban the sale and distribution of assault weapons. Assault weapons are designed and sold as tools of war. There is absolutely no reason why these firearms should be sold to civilians. Prohibit high-capacity ammunition magazines. Crack down on “straw purchases” where people buy guns for criminals. ",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Taxes",
            //        Stance = "Pass the For the 99.8 Percent Act to establish a progressive estate tax on multi-millionaire and billionaire inheritances. Eliminate offshore tax scams through the Corporate Tax Dodging Prevention Act. Tax Wall Street speculators through the Inclusive Prosperity Act. Scrap the income cap on Social Security payroll taxes through the Social Security Expansion Act so that millionaires and billionaires pay more into the system. End special tax breaks on capital gains and dividends for the top 1%. Substantially increase the top marginal tax rate on income above $10 million. Close tax loopholes that benefit the wealthy and large corporations. ",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Empower the People of Puerto Rico",
            //        Stance = "When we are in the White House, we will: Finally repair the damage from Hurricanes Irma and Maria and rebuild Puerto Rico.It is unconscionable that in the wealthiest nation in the world we have allowed our fellow citizens to suffer for so long.The full resources of the United States must be brought to bear on this crisis, for as long as necessary.Restore self - rule in Puerto Rico by ending the reign of greedy Wall Street vulture funds that have a stranglehold on Puerto Rico’s future, return control of the island to the people of Puerto Rico, and give the territory the debt relief it so desperately needs to rebuild with dignity.Ensure a strong social safety net for the people of Puerto Rico by ensuring access to health care, nutrition assistance, veterans benefits, and quality public schools. ",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "LGBTQ Equality",
            //        Stance = "Pass the Equality Act, the Every Child Deserves a Family Act and other bills to prohibit discrimination against LGBTQ people. Ensure LGBTQ people have comprehensive health insurance without discrimination from providers. Protect the rights of LGBTQ people around the world. Advance policies to ensure students can attend school without fear of bullying, and work to substantially reduce suicides. ",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Disability Rights",
            //        Stance = "Protect and expand the Social Security Disability Insurance program. Increase educational opportunities for persons with disabilities, including fully funding the Individuals with Disabilities Education Act and expanding vocational education opportunities. Guarantee jobs that pay living wages to all persons with disabilities who want to work through a federal job guarantee program. In addition to the job guarantee, Bernie Sanders will end the sub-minimum wage for individuals with disabilities. Ratify the Convention on the Rights of Persons with Disabilities. Enact a Medicare-for-all program that includes home-based and community-based care. Work to ensure no person with a disability experiences discrimination or barriers to living a full and productive life.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Women’s Rights",
            //        Stance = "Amy is deeply committed to tackling the climate crisis and believes that it is an urgent priority for our communities, for our economy and for our planet. She is a co-sponsor of a Green New Deal and has signed the No Fossil Fuel Money Pledge. On day one of Amy’s presidency she will get us back into the International Climate Change Agreement. On day two and day three, she will bring back the clean power rules and gas mileage standards that the Obama Administration put into place. And she will put forward sweeping legislation that provides a landmark investment in clean-energy jobs and infrastructure, provides incentives for tougher building codes, promotes rural renewable energy and development, and promotes “buy clean” policies.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Foreign Policy",
            //        Stance = "Adopt Equal Pay for Equal Work through the Paycheck Fairness Act. Fully fund Planned Parenthood, Title X, and other initiatives that protect women’s health, access to contraception, and the availability of a safe and legal abortion. Expand the WIC program for pregnant mothers, infants, and children. Oppose all efforts to undermine or overturn Roe v. Wade, and appoint federal judges who will uphold women’s most fundamental rights. Immediately reauthorize the Violence Against Women Act. Pass the Equal Rights Amendment. Fight to end sexual harassment in workplaces, the military, and other institutions. Protect women from harassment, discrimination, and violence in educational institutions by protecting and enforcing Title IX.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Commitment To Our Veterans",
            //        Stance = "Fully fund and expand the VA so that every veteran gets the care that they have earned and deserve. Get veterans compensated faster by improving how compensation claims are processed. Expand the VA’s Caregivers Program. Expand mental health services for veterans. Make comprehensive dental care available to all veterans at the VA. ",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Combat Climate Change",
            //        Stance = "Pass a Green New Deal to save American families money and generate millions of jobs by transforming our energy system away from fossil fuels to 100% energy efficiency and sustainable energy. A Green New Deal will protect workers and the communities in which they live to ensure a transition to family-sustaining wage, union jobs. Invest in infrastructure and programs to protect the frontline communities most vulnerable to extreme climate impacts like wildfires, sea level rise, drought, floods, and extreme weather like hurricanes. Reduce carbon pollution emissions from our transportation system by building out high-speed passenger rail, electric vehicles, and public transit. Ban fracking and new fossil fuel infrastructure and keep oil, gas, and coal in the ground by banning fossil fuel leases on public lands. End exports of coal, natural gas, and crude oil.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Social Security",
            //        Stance = "Expand and extend Social Security for the next 52 years by making sure that all income over $250,000 a year is subject to the Social Security payroll tax, with the Social Security Expansion Act.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Jobs for All",
            //        Stance = "As part of the Green New Deal, we need millions of workers to rebuild our crumbling infrastructure—roads, bridges, drinking water systems, wastewater plants, rail, schools, affordable housing—and build our 100% sustainable energy system. This infrastructure is critical to a thriving, green economy. At a time when our early childhood education system is totally inadequate, we need hundreds of thousands of workers to provide quality care to the young children of our country. As the nation ages, we will need many more workers to provide supportive services for seniors to help them age in their homes and communities, which is where they want to be. ",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Working Families",
            //        Stance = "We must: Raise the minimum wage to a living wage of at least $15 an hour.Enact a universal childcare and pre - kindergarten program.Make sure women and men are paid the same wage for the same job through the Paycheck Fairness Act.Guarantee all workers paid family and medical leave, paid sick leave and paid vacation.Make it easier for workers to join unions through the Workplace Democracy Act.Make quality education a right.Implement a green jobs program.",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "College for All",
            //        Stance = "Every young person, regardless of their family income, should have the opportunity to attend college. It is unacceptable, for example, that 28% of African American students are forced to drop out of college after one year due to costs. The federal government shouldn’t make billions of dollars in profit off of student loans while students are drowning in debt. We should invest in young Americans—not leverage their futures. That’s why we must: Make public colleges, universities, and trade schools tuition-free",
            //        CandidateId = 1
            //    },
            //    new Models.CampaignTheme()
            //    {
            //        Issue = "Health Care ",
            //        Stance = "Joining every other major country on Earth and guaranteeing health care to all people as a right, not a privilege, through a Medicare-for-all, single-payer program. And to lower the prices of prescription drugs now, we need to: Allow Medicare to negotiate with the big drug companies to lower prescription drug prices with the Medicare Drug Price Negotiation Act.Allow patients, pharmacists, and wholesalers to buy low - cost prescription drugs from Canada and other industrialized countries with the Affordable and Safe Prescription Drug Importation Act.Cut prescription drug prices in half, with the Prescription Drug Price Relief Act, by pegging prices to the median drug price in five major countries: Canada, the United Kingdom, France, Germany, and Japan.",
            //        CandidateId = 1
            //    }
            //);
        }
    }
}
