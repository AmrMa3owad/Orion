using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class PreCommunityService
        : BaseService<PreCommunity, int>,
            IPreCommunityService
    {
        public PreCommunityService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}