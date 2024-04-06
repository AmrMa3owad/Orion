using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Orphanage : BaseEntity<int>
    {
        public Orphanage()
        {
            Freelancers = new HashSet<Freelancer>();
            Above12s = new HashSet<Above12>();
        }
        public string OrphanageName { get; set; }
        public int OrphanageNumber { get; set; }
        public string OrphanageAddress { get; set; }
        public virtual ICollection<Freelancer> Freelancers { get; set; }
        public virtual ICollection<Above12> Above12s { get; set; }
    }
}
