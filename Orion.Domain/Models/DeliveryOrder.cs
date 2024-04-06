using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class DeliveryOrder : BaseEntity<int> //Bridge
    {
        public double ShippingFees { get; set; }
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Delivery Delivery { get; set; }

    }
}
