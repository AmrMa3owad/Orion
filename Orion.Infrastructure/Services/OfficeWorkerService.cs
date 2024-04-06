using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class OfficeWorkerService
        : BaseService<OfficeWorker, int>,
            IOfficeWorkerService
    {
        public OfficeWorkerService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}