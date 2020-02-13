using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapStone.Models
{
    public class Candidate
    {
        [Key]
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
        public double Polling { get; set; }
        public string Party { get; set; }
        public string ImgPath { get; set; }
    }
}