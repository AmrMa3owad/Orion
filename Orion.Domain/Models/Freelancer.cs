using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Freelancer : BaseUser<int>
    {
        public Freelancer()
        {
            Products = new HashSet<Product>();
        }
        public int Earnings { get; set; }
        public byte[] StarPhoto { get; set; }
        public string Skill { get; set; }
        public int? SupervisorId { get; set; }
        public int? OrphanageId { get; set; }
        public string FreelancerType { get; set; }

        public virtual Orphanage Orphanage { get; set; }
        public virtual User User { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
