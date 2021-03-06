﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapStoneApp.Models
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        [ForeignKey("Forum")]
        public int? ForumId { get; set; }
        public Forum Forum { get; set; }
        [ForeignKey("Client")]
        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}