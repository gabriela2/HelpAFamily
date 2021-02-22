using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Models
{
    [Table("Demands")]
    public class Demand
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AdId { get; set; }
        public DateTime CreatedAt { get; set; }
        public float Quantity { get; set; }
        public int? DeliveryTypeId { get; set; }

        public virtual User User { get; set; }
        public virtual Ad Ad { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }
    }
}
