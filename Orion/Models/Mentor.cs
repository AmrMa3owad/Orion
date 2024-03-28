namespace Orion.Models
{
    public class Mentor : BaseEntity<int>
    {
        public string MentorArea { get; set; }
        public int OrphansNumber { get; set; }
        public int VisitNumber { get; set; }
        public int CraftId { get; set; }

        public virtual Craft Craft { get; set; }
    }
}
