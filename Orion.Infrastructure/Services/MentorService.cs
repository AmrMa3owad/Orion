using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class MentorService
        : BaseService<Mentor, int>,
            IMentorService
    {
        public MentorService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}