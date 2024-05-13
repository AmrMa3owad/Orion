using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Employee : BaseEntity<int>
    {
        public Employee()
        {
            EmployeeAdmins = new HashSet<EmployeeAdmin>();
            EmployeeSupervisors = new HashSet<EmployeeSupervisor>();
            EmployeeDeliveries = new HashSet<EmployeeDelivery>();
            EmployeeOfficeWorkers = new HashSet<EmployeeOfficeWorker>();
            UserEmployees = new HashSet<UserEmployee>();
        }
        public string EmployeePension { get; set; }
        public int EmployeeInsurance { get; set; }
        public string EmployeeRole { get; set; }
        public int EmployeeSalary { get; set; }
        public DateTime EmployeeDateOfJoin { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeQualifications { get; set; }

        public virtual ICollection<EmployeeAdmin> EmployeeAdmins { get; set; }
        public virtual ICollection<EmployeeSupervisor> EmployeeSupervisors { get; set; }
        public virtual ICollection<EmployeeDelivery> EmployeeDeliveries { get; set; }
        public virtual ICollection<EmployeeOfficeWorker> EmployeeOfficeWorkers { get; set; }
        public virtual ICollection<UserEmployee> UserEmployees { get; set; }

    }
}
