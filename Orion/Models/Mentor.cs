using Microsoft.AspNetCore.Identity;

namespace Orion.Models
{
    public class Mentor : IdentityUser<int>
    {
        public string MentorArea { get; set; }
        public int OrphanNumber { get; set; }
        public int VisitNumber { get; set; }
        public int CraftId { get; set; }

        public virtual Craft Craft { get; set; }
    }
}
