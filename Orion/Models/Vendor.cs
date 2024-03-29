namespace Orion.Models
{
    public class Vendor : BaseEntity<int>
    {
        public Vendor()
        {
            MaterialVendor = new HashSet<MaterialVendor>();
        }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public virtual ICollection<MaterialVendor> MaterialVendor { get; set; }

    }
}
