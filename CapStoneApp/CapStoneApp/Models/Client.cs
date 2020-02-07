﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapStoneApp.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Affiliadated Party")]
        public string Party { get; set; }
        public int? CandidateId { get; set; }
        public int? DislikeId { get; set; }
        [Display(Name = "Candidate Voted For")]
        public string CandidateName { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}