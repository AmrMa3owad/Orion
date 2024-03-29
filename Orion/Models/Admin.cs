using Orion.Models.Common;

namespace Orion.Models
{
    public class Admin : BaseEntity<int> , IEmployee
    {
        public Admin()
        {
            Feedbacks = new HashSet<Feedback>();
        }
        public int WebsiteId { get; set; }
        public int DeviceId { get; set; }
        public string EmployeePension { get; set; }
        public int EmployeeInsurance { get; set; }
        public string EmployeeRole { get; set; }
        public int EmployeeSalary { get; set; }
        public DateTime EmployeeDateOfJoin { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeQualifications { get; set; }
        public virtual Website Website { get; set; }
        public virtual Device Device { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
