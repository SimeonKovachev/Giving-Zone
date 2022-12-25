using System.ComponentModel.DataAnnotations;

namespace Giving_Zone.Models
{
    public class Volunteer : User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Skills { get; set; }
        public virtual ICollection<VolunteerOpportunity> Opportunities { get; set; }

    }
}
