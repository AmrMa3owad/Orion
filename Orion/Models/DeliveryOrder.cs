using Orion.Models.Common;

namespace Orion.Models
{
    public class DeliveryOrder : BaseEntity<int> , IOrder
    {
        public double ShippingFees { get; set; }
        public int DeliveryId { get; set; }
        public int OrderPrice { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderAmount { get; set; }
        public string OrderComments { get; set; }

        public virtual Delivery Delivery { get; set; }

    }
}
