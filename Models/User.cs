using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Giving_Zone.Models
{
    public class User
    {

        [Key]
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public UserType UserType { get; set; }

    }
    
    


    public enum UserType
    {
        Organization,
        Volunteer
    }
}
