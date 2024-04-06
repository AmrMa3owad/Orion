using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class OrphanageService
        : BaseService<Orphanage, int>,
            IOrphanageService
    {
        public OrphanageService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}