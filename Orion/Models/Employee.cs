using Orion.Models.Common;

namespace Orion.Models
{
    public class Employee : BaseEntity<int>, IEmployee
    {
        public string EmployeePension { get; set; }
        public int EmployeeInsurance { get; set; }
        public string EmployeeRole { get; set; }
        public int EmployeeSalary { get; set; }
        public DateTime EmployeeDateOfJoin { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeQualifications { get; set; }
    }
}
