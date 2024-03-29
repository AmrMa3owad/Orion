using Microsoft.AspNetCore.Identity;

namespace Orion.Models
{
    public class Customer : IdentityUser<int>
    {
        public Customer()
        {
            CustomerProducts = new HashSet<CustomerProduct>();
            CustomerAdvertisements = new HashSet<CustomerAdvertisement>();
            Events = new HashSet<Event>();
            Feedbacks = new HashSet<Feedback>();
        }
        public int DonationId { get; set; }
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int WebsiteId { get; set; }

        public virtual Donation Donation { get; set; }       
        public virtual Payment Payment { get; set; }
        public virtual Order Order { get; set; }
        public virtual Website Website { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
        public virtual ICollection<CustomerAdvertisement> CustomerAdvertisements { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
