using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Freelancer : BaseUser<int>
    {
        public Freelancer()
        {
            FreelancerAbove12s = new HashSet<FreelancerAbove12>();
            FreelancerUnder12s = new HashSet<FreelancerUnder12>();
        }
        public int Earnings { get; set; }
        public string ProductType { get; set; }
        public byte[] StarPhoto { get; set; }
        public string Skill { get; set; }
        public int? OrphanageId { get; set; }
        public string FreelancerType { get; set; }

        public virtual Orphanage Orphanage { get; set; }
        public virtual ICollection<FreelancerAbove12> FreelancerAbove12s { get; set; }
        public virtual ICollection<FreelancerUnder12> FreelancerUnder12s { get; set; }
    }
}
