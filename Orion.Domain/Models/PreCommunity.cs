using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class PreCommunity : BaseEntity<int>
    {
        public PreCommunity()
        {
            PremiumUsers = new HashSet<PremiumUser>();
        }

        public virtual ICollection<PremiumUser> PremiumUsers { get; set; }
    }
}
