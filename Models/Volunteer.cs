namespace Giving_Zone.Models
{
    public class Volunteer
    {
        public int VolunteerId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
        public string Skills { get; set; }
    }
}
