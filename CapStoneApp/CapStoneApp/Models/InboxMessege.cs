using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapStoneApp.Models
{
    public class InboxMessege
    {
        [Key]
        public int Id { get; set; }
        public string Messege { get; set; }
        [ForeignKey("Inbox")]
        public int InboxId { get; set; }
        public Inbox Inbox { get; set; }
    }
}