using Orion.Models.Common;

namespace Orion.Models
{
    public class Vendor : BaseEntity<int>
    {
        public Vendor()
        {
            MaterialVendors = new HashSet<MaterialVendor>();
        }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public virtual ICollection<MaterialVendor> MaterialVendors { get; set; }

    }
}
