using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public class SupervisorService
        : BaseServiceEmployee<Supervisor, int>,
            ISupervisorService
    {
        public SupervisorService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}