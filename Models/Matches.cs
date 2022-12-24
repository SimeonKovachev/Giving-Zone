namespace Giving_Zone.Models
{
    public class Matches
    {
        public int MatchId { get; set; }
        public int OrganizationId { get; set; }
        public int VolunteerId { get; set; }
        public MatchStatus Status { get; set; }

        public Organization Organization { get; set; }
        public Volunteer Volunteer { get; set; }
    }

    public enum MatchStatus
    {
        Pending,
        Approved,
        Declined
    }
}

