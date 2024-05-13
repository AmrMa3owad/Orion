using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public class Above12Service
        : BaseService<Above12, int>,
            IAbove12Service
    {
        public Above12Service(
            AppDbContext context)
            : base(context)
        {

        }
    }
}
