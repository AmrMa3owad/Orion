namespace Orion.Models
{
    public class Mentor : BaseEntity<int>
    {
        public string MentorArea { get; set; }
        public int OrphansNumber { get; set; }
        public int VisitNumber { get; set; }
    }
}
