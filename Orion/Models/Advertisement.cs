using Orion.Models.Common;

namespace Orion.Models
{
    public class Advertisement : BaseEntity<int>
    {
        public Advertisement()
        {
            CustomerAdvertisements = new HashSet<CustomerAdvertisement>();
            SponsorAdvertisements = new HashSet<SponsorAdvertisement>();
        }
        public string AdvertisementType { get; set; }
        public virtual ICollection<CustomerAdvertisement> CustomerAdvertisements { get; set; }
        public virtual ICollection<SponsorAdvertisement> SponsorAdvertisements { get; set; }
    }
}
