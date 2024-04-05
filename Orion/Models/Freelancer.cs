using Orion.Models.Common;

namespace Orion.Models
{
    public class Freelancer : BaseUser<int>
    {
        public int OrphanageId { get; set; }
        public int Earnings { get; set; }
        public int OrphansNumber { get; set; }
        public string ProductType { get; set; }

        public virtual Orphanage Orphanage { get; set; }
    }
}
