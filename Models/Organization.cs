using System.ComponentModel.DataAnnotations;

namespace Giving_Zone.Models
{
    public class Organization : User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<VolunteerOpportunity> Opportunities { get; set; }

    }
}
