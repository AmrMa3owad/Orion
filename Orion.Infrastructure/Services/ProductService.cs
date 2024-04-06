using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class ProductService
        : BaseService<Product, int>,
            IProductService
    {
        public ProductService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}