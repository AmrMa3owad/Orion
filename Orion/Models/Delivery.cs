namespace Orion.Models
{
    public class Delivery : Employee
    {
        public Delivery()
        {
            DeliveryOrders = new HashSet<DeliveryOrder>();
        }
        public string DeliveryShift { get; set; }
        public int VechileNumber { get; set; }
        public string DeliveryLicense { get; set; }

        public virtual ICollection<DeliveryOrder> DeliveryOrders { get; set; }
    }
}
