using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public class PremiumUserService
        : BaseService<PremiumUser, int>,
            IPremiumUserService
    {
        public PremiumUserService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}