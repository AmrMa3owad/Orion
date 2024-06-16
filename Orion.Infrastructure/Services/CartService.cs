using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class CartService
        : BaseService<Cart, int>,
            ICartService
    {
        public CartService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}