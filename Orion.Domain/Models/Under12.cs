using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Under12 : BaseEntity<int> 
    {
        public Under12()
        {
            FreelancerUnder12s = new HashSet<FreelancerUnder12>();
        }
        public int SupervisorId { get; set; }

        public virtual Supervisor Supervisor { get; set; }
        public virtual ICollection<FreelancerUnder12> FreelancerUnder12s { get; set; }

    }
}
