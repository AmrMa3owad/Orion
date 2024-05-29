using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Employee : BaseEntity<int>
    {
        public Employee()
        {
            EmployeeAdmins = new HashSet<EmployeeAdmin>();
            EmployeeSupervisors = new HashSet<EmployeeSupervisor>();
            EmployeeOfficeWorkers = new HashSet<EmployeeOfficeWorker>();
            UserEmployees = new HashSet<UserEmployee>();
        }
        public string EmployeeType { get; set; }
        public int EmployeeSalary { get; set; }
        public string EmployeeDateOfJoin { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeQualifications { get; set; }

        public virtual ICollection<EmployeeAdmin> EmployeeAdmins { get; set; }
        public virtual ICollection<EmployeeSupervisor> EmployeeSupervisors { get; set; }
        public virtual ICollection<EmployeeOfficeWorker> EmployeeOfficeWorkers { get; set; }
        public virtual ICollection<UserEmployee> UserEmployees { get; set; }

    }
}
