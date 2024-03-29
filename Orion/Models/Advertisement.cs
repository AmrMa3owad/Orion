namespace Orion.Models
{
    public class Advertisement : BaseEntity<int>
    {
        public Advertisement()
        {
            CustomerAdvertisement = new HashSet<CustomerAdvertisement>();
            SponsorAdvertisement = new HashSet<SponsorAdvertisement>();
        }
        public string AdvertisementType { get; set; }
        public virtual ICollection<CustomerAdvertisement> CustomerAdvertisement { get; set; }
        public virtual ICollection<SponsorAdvertisement> SponsorAdvertisement { get; set; }
    }
}
