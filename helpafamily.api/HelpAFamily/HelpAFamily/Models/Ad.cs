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
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public float Quantity { get; set; }
        public int? UnitOfMeasureTypeId { get; set; }
        public float Limit { get; set; }
        public int NumberOfPhotos { get; set; }
        public int? CategoryId { get; set; }
        public int? DeliveryTypeId { get; set; }
        public int? StatusId { get; set; }

        public virtual UnitOfMeasureType UnitOfMeasureType { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }
        public virtual Category Category { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual List<Demand> Demands { get; set; }
        public virtual Chat Chat { get; set; }
        public List<Picture> Pictures { get; set; }


    }
}
