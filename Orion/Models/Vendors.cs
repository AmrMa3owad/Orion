namespace Orion.Models
{
    public class Vendors : BaseEntity<int>
    {
        public string VendorsName { get; set; }
        public string VendorsAddress { get; set; }
    }
}
