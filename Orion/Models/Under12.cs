using Orion.Models.Common;

namespace Orion.Models
{
    public class Under12 : BaseEntity<int> , IFreelancer
    {
        public int Earnings { get; set; }
        public int OrphansNumber { get; set; }
        public string ProductType { get; set; }
        public int SupervisorId { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}
