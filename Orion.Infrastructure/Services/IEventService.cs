using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public interface IEventService :
        IBaseService<Event, int>
    {
    }
}
