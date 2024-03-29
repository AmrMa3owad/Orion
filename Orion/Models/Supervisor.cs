using Orion.Models.Common;

namespace Orion.Models
{
    public class Supervisor: BaseEntity<int> , IEmployee
    {
        public Supervisor()
        {
            Under12s = new HashSet<Under12>();
            Products = new HashSet<Product>();
        }
        public string EmployeePension { get; set; }
        public int EmployeeInsurance { get; set; }
        public string EmployeeRole { get; set; }
        public int EmployeeSalary { get; set; }
        public DateTime EmployeeDateOfJoin { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeQualifications { get; set; }
        public virtual ICollection<Under12> Under12s { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
