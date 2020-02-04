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
        public string Bio { get; set; }
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