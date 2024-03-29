using Orion.Models.Common;

namespace Orion.Models
{
    public class Under12 : Freelancer
    {
        public int SupervisorId { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}
