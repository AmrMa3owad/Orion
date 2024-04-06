using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class OrderService
        : BaseService<Order, int>,
            IOrderService
    {
        public OrderService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}