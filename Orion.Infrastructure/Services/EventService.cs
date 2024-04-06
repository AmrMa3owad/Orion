using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class EventService
        : BaseService<Event, int>,
            IEventService
    {
        public EventService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}