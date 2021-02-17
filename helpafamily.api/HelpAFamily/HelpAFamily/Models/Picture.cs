using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Models
{
    [Table("Pictures")]
    public class Picture
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int AdId { get; set; }
        public string Name { get; set; }

        public virtual Ad Ad { get; set; }
    }
}
