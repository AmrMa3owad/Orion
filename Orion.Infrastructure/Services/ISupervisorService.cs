using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface ISupervisorService :
        IBaseService<Supervisor, int>
    {
    }
}
