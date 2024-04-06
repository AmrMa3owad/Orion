using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class MaterialVendorService
        : BaseService<MaterialVendor, int>,
            IMaterialVendorService
    {
        public MaterialVendorService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}