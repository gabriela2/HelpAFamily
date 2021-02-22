using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Models
{
    [Table("Chat")]
    public class Chat
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int SenderId { get; set;}
        public string SenderUsername { get; set; }
        public int ReceiverId { get; set; }
        public string ReceiverUsername { get; set; }
        public string Content { get; set; }
        public DateTime DataRead { get; set; }
        public DateTime MessageSent { get; set; }
        public bool SenderDeleted { get; set; }
        public bool ReceiverDeleted { get; set; }
        public int? DonationId { get; set; }
        public int? AdId { get; set; }

        public virtual Donation Donation { get; set; }
        public virtual Ad Ad { get; set; }
        public virtual User User { get; set; }
    }
}
