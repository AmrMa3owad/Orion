using Orion.Models.Common;

namespace Orion.Models
{
    public class Delivery : BaseEntity<int> , IEmployee
    {
        public Delivery()
        {
            DeliveryOrders = new HashSet<DeliveryOrder>();
        }
        public string EmployeePension { get; set; }
        public int EmployeeInsurance { get; set; }
        public string EmployeeRole { get; set; }
        public int EmployeeSalary { get; set; }
        public DateTime EmployeeDateOfJoin { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeQualifications { get; set; }
        public string DeliveryShift { get; set; }
        public int VechileNumber { get; set; }
        public string DeliveryLicense { get; set; }

        public virtual ICollection<DeliveryOrder> DeliveryOrders { get; set; }
    }
}
