using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class SponsorService
        : BaseService<Sponsor, int>,
            ISponsorService
    {
        public SponsorService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}