﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Models
{
    [Table("Donations")]
    public class Donation
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int UserSenderId { get; set; }
        public int UserReceiverId { get; set; }
        public DateTime CreatedAt { get; set; }
        public float Amount { get; set; }

        public virtual User User { get; set; }
        //public virtual User UserReceiver { get; set; }
        public virtual Chat Chat { get; set; }
    }
}
