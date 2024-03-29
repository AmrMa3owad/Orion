using Orion.Models.Common;

namespace Orion.Models
{
    public class Material : BaseEntity<int>
    {
        public Material()
        {
            MaterialVendors = new HashSet<MaterialVendor>();

        }
        public string MaterialType { get; set; }
        public int MaterialPrice { get; set; }
        public int MaterialQuantity { get; set; }
        public virtual ICollection<MaterialVendor> MaterialVendors { get; set; }

    }
}
