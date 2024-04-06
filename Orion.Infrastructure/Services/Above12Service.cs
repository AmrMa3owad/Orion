using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

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
