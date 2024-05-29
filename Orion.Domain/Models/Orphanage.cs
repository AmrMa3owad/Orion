using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Orphanage : BaseEntity<int>
    {
        public Orphanage()
        {
            Freelancers = new HashSet<Freelancer>();
            Above12s = new HashSet<Above12>();
            SupervisorOrphanages = new HashSet<SupervisorOrphanage>();

        }
        public string OrphanageName { get; set; }
        public int OrphanageRegion { get; set; }
        public string OrphanageInfo { get; set; }
        public byte[] OrphanageLogo { get; set; }

        public virtual ICollection<Freelancer> Freelancers { get; set; }
        public virtual ICollection<Above12> Above12s { get; set; }
        public virtual ICollection<SupervisorOrphanage> SupervisorOrphanages { get; set; }

    }
}
