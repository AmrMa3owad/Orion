namespace Orion.Models
{
    public class Event : BaseEntity<int>
    {
        public Event()
        {
            Product = new HashSet<Product>();
            Sponsor = new HashSet<Sponsor>();
        }
        public DateTime EventDate { get; set; }
        public string EventTitle { get; set; }
        public string EventPlace { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Sponsor> Sponsor { get; set; }
        public virtual Booth Booth { get; set; }

    }
}
