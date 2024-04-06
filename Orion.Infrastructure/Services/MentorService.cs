using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public class MentorService
        : BaseUserService<Mentor, int>,
            IMentorService
    {
        public MentorService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}