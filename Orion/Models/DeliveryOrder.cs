namespace Orion.Models
{
    public class DeliveryOrder : Order
    {
        public int DeliveryId { get; set; }
        public virtual Delivery Delivery { get; set; }

    }
}
