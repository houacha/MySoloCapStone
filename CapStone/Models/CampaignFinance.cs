using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapStone.Models
{
    public class CampaignFinance
    {
        [Key]
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }
}