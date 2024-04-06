using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class DeviceService
        : BaseService<Device, int>,
            IDeviceService
    {
        public DeviceService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}