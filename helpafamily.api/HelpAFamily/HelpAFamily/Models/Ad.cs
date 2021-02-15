using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Models
{
    [Table("Ads")]
    public class Ad
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public string Picture { get; set; }
        public int TypeId { get; set; }
        public int DeliveryTypeId { get; set; }
        public string Status { get; set; }

    }
}
