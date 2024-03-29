namespace Orion.Models
{
    public class Customer :BaseEntity<int>
    {
        public Customer()
        {
            CustomerProduct = new HashSet<CustomerProduct>();
            CustomerAdvertisement = new HashSet<CustomerAdvertisement>();
            Event = new HashSet<Event>();
            Feedback = new HashSet<Feedback>();
        }

        public int DonationId { get; set; }
        public virtual Donation Donation { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProduct { get; set; }
        public virtual ICollection<CustomerAdvertisement> CustomerAdvertisement { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual Order Order { get; set; }
        public virtual Website Website { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }

    }
}
