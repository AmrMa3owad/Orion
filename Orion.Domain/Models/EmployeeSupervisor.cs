using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class EmployeeSupervisor : BaseEntity<int>
    {
        public int EmployeeId { get; set; }
        public int SupervisorId { get; set; }

        public virtual Supervisor Supervisor { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
