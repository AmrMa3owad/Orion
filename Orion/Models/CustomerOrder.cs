namespace Orion.Models
{
    public class CustomerOrder
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
