using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Under12 : BaseFreelancer<int> 
    {
        public int SupervisorId { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}
