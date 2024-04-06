using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface ICustomerService :
        IBaseService<Customer, int>
    {
    }
}
