using Orion.Models.Common;

namespace Orion.Models
{
    public class Orphanage : BaseEntity<int>
    {
        public Orphanage()
        {
            Freelancers = new HashSet<Freelancer>();
        }
        public string OrphanageName { get; set; }
        public int OrphanageNumber { get; set; }
        public string OrphanageAddress { get; set; }
        public virtual ICollection<Freelancer> Freelancers { get; set; }

    }
}
