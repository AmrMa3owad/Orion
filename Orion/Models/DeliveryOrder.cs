namespace Orion.Models
{
    public class DeliveryOrder : BaseEntity<int>
    {
        public virtual Delivery Delivery { get; set; }

    }
}
