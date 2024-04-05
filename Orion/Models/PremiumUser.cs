using Orion.Models.Common;

namespace Orion.Models
{
    public class PremiumUser : BaseUser<int>
    {
        public int Fees { get; set; }
        public int PreCommunityId { get; set; }

        public virtual PreCommunity PreCommunity { get; set; }
    }
}
