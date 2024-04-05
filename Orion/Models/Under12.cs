using Orion.Models.Common;

namespace Orion.Models
{
    public class Under12 : BaseFreelancer<int> 
    {
        public int SupervisorId { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}
