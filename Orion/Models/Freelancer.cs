using Orion.Models.Common;

namespace Orion.Models
{
    public class Freelancer : BaseFreelancer<int>
    {
        public int OrphanageId { get; set; }

        public virtual Orphanage Orphanage { get; set; }
    }
}
