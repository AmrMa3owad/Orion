using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Mentor : BaseEntity<int>
    {
        public Mentor()
        {
            UserMentors = new HashSet<UserMentor>();
        }
        public string MentorArea { get; set; }
        public int OrphansNumber { get; set; }
        public int VisitNumber { get; set; }
        public int CraftId { get; set; }

        public ICollection<UserMentor> UserMentors { get; set; }
        public virtual Craft Craft { get; set; }
    }
}
