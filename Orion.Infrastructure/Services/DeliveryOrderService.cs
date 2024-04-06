using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class DeliveryOrderService
        : BaseService<DeliveryOrder, int>,
            IDeliveryOrderService
    {
        public DeliveryOrderService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}