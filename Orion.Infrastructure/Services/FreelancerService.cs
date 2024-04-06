using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class FreelancerService
        : BaseService<Freelancer, int>,
            IFreelancerService
    {
        public FreelancerService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}