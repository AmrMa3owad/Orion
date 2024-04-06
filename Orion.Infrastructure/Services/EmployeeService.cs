using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public class EmployeeService
        : BaseUserService<Employee, int>,
            IEmployeeService
    {
        public EmployeeService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}