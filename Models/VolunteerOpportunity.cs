using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Giving_Zone.Models
{
    public class VolunteerOpportunity
    {
        //This is the oppurtunities the organizations will create
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Relationships
        public int OrganizationId { get; set; }
        [ForeignKey("OrganizationId")]
        public virtual Organization Organization { get; set; }
        public int VolunteerId { get; set; }
        [ForeignKey("VolunteerId")]
        public virtual Volunteer Volunteer { get; set; }
    }
}
