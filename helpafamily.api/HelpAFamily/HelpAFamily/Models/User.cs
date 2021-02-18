using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Models
{
    [Table ("Users")]
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int RoleTypeId { get; set; }
        public int UserTypeId { get; set; }

        public virtual RoleType RoleTypes { get; set; }
        public virtual UserType UserTypes { get; set; }
        public List<Ad> Ads { get; set; }
        public List<User_X_Address> User_X_Addresses { get; set; }
        public List<Demand> Demands { get; set; }
        public List<Chat> Chats{ get; set; }
        public List<Donation> Donations{ get; set; }

    }
}
