using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class OfficeWorker : BaseEntity<int>
    {
        public OfficeWorker()
        {
            Websites = new HashSet<Website>();
            Feedbacks = new HashSet<Feedback>();
            EmployeeOfficeWorkers = new HashSet<EmployeeOfficeWorker>();
        }
        public string OfficeWorkerDepartment { get; set; }
        public int? DeviceId { get; set; }
        
        public virtual Device Device { get; set; }
        public virtual ICollection<Website> Websites { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<EmployeeOfficeWorker> EmployeeOfficeWorkers { get; set; }
    }
}
