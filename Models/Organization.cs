namespace Giving_Zone.Models
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        //Relationships
       

    }
}
