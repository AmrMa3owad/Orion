using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class FeedbackService
        : BaseService<Feedback, int>,
            IFeedbackService
    {
        public FeedbackService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}