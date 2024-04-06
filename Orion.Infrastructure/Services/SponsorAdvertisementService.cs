using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class SponsorAdvertisementService
        : BaseService<SponsorAdvertisement, int>,
            ISponsorAdvertisementService
    {
        public SponsorAdvertisementService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}