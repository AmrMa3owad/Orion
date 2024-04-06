using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class BoothOrderService
        : BaseService<BoothOrder, int>,
            IBoothOrderService
    {
        public BoothOrderService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}