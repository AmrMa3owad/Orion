using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class MaterialService
        : BaseService<Material, int>,
            IMaterialService
    {
        public MaterialService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}