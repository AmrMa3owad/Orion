namespace Orion.Models
{
    public class MaterialVendor
    {
        public int MaterialId { get; set; }
        public int VendorId { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual Material Material { get; set; }
    }
}
