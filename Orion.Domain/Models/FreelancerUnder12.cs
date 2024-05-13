using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class FreelancerUnder12 : BaseEntity<int>
    {
        public int FreelancerId { get; set; }
        public int Under12Id { get; set; }

        public virtual Freelancer Freelancer { get; set; }
        public virtual Under12 Under12 { get; set; }
    }
}
