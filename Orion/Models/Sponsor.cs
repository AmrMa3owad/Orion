namespace Orion.Models
{
    public class Sponsor : BaseEntity<int>
    {
        public Sponsor()
        {
            SponsorAdvertisement = new HashSet<SponsorAdvertisement>();

        }
        public string SponsorName { get; set; }
        public string SponsorEmail { get; set; }
        public int SponsorPhone { get; set; }
        public string SponsorAddress { get; set; }
        public string BusinessType { get; set; }

        public virtual Donation Donation { get; set; }
        public virtual Event Event { get; set; }
        public virtual ICollection<SponsorAdvertisement> SponsorAdvertisement { get; set; }


    }
}
