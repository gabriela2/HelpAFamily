﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Models
{
    [Table("User_x_Address")]
    public class User_X_Address
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }

        public virtual User User { get; set; }
        public virtual Address Address { get; set; }
    }
}
