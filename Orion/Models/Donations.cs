namespace Orion.Models
{
    public class Donations : BaseEntity<int>
    {
        public string DonationsType { get; set; }
        public int DonationsQuantity { get; set; }
        public DateTime DonationsTime { get; set; }
        public string DonationsMethod { get; set; }
    }
}
