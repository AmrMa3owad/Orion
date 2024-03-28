namespace Orion.Models
{
    public class Customer :BaseEntity<int>
    {
        public Customer()
        {
            CustomerOrders = new HashSet<CustomerOrder>();
        }

        public int DonationId { get; set; }
        public virtual Donation Donation { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrders { get; }
    }
}
