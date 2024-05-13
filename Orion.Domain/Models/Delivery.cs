using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Delivery : BaseEntity<int> 
    {
        public Delivery()
        {
            DeliveryOrders = new HashSet<DeliveryOrder>();
            EmployeeDeliveries = new HashSet<EmployeeDelivery>();
        }
        public string DeliveryShift { get; set; }
        public int VechileNumber { get; set; }
        public string DeliveryLicense { get; set; }

        public virtual ICollection<DeliveryOrder> DeliveryOrders { get; set; }
        public virtual ICollection<EmployeeDelivery> EmployeeDeliveries { get; set; }
    }
}
