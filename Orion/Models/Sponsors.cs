namespace Orion.Models
{
    public class Sponsors : BaseEntity<int>
    {
        public string SponsorsName { get; set; }
        public string SponsorsEmail { get; set; }
        public string SponsorsPhone { get; set; }
        public string SponsorsAddress { get; set; }
        public string BusinessType { get; set; }
    }
}
