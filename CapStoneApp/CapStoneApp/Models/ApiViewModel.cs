using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapStoneApp.Models
{
    public class ApiViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Birthdate { get; set; }
        public string BirthPlace { get; set; }
        public string Hometown { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string Children { get; set; }
        public string Education { get; set; }
        public double? Polling { get; set; }
        public string Party { get; set; }
        public string Issue { get; set; }
        public string Stance { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public double? Amount { get; set; }
        public string Type { get; set; }
        public string Experience { get; set; }
        public string WebsiteUrl { get; set; }
        public int? CandidateId { get; set; }
    }
}