using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class FreelancerService
        : BaseServiceUser<Freelancer, int>,
            IFreelancerService
    {
        public FreelancerService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}