namespace Orion.Models
{
    public class Delivery : BaseEntity<int>
    {
        public string DeliveryShift { get; set; }
        public int VechileNumber { get; set; }
        public string DeliveryLicense { get; set; }
    }
}
