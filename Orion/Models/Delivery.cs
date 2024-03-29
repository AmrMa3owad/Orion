namespace Orion.Models
{
    public class Delivery : BaseEntity<int>
    {
        public Delivery()
        {
            DeliveryOrder = new HashSet<DeliveryOrder>();
        }
        public string DeliveryShift { get; set; }
        public int VechileNumber { get; set; }
        public string DeliveryLicense { get; set; }

        public virtual ICollection<DeliveryOrder> DeliveryOrder { get; set; }
    }
}
