using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public class Under12Service
        : BaseService<Under12, int>,
            IUnder12Service
    {
        public Under12Service(
            AppDbContext context)
            : base(context)
        {

        }
    }
}