using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class FreelancerAbove12 : BaseEntity<int>
    {
        public int FreelancerId { get; set; }
        public int Above12Id { get; set; }

        public virtual Freelancer Freelancer { get; set; }
        public virtual Above12 Above12 { get; set; }
    }
}
