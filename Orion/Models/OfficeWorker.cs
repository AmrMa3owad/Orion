using Orion.Models.Common;

namespace Orion.Models
{
    public class OfficeWorker : BaseEntity<int> , IEmployee
    {
        public OfficeWorker()
        {
            Websites = new HashSet<Website>();
            Feedbacks = new HashSet<Feedback>();
        }
        public string OfficeWorkerDepartment { get; set; }
        public int DeviceId { get; set; }
        public string EmployeePension { get; set; }
        public int EmployeeInsurance { get; set; }
        public string EmployeeRole { get; set; }
        public int EmployeeSalary { get; set; }
        public DateTime EmployeeDateOfJoin { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeQualifications { get; set; }
        public virtual Device Device { get; set; }
        public virtual ICollection<Website> Websites { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
