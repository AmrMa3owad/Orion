using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class PremiumUser : BaseUser<int>
    {
        public int Fees { get; set; }
        public int PreCommunityId { get; set; }

        public virtual PreCommunity PreCommunity { get; set; }
    }
}
