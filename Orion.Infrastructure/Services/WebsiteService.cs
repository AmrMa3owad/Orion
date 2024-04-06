using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Models;

namespace Orion.Infrastructure.Services
{
    public class WebsiteService
        : BaseService<Website, int>,
            IWebsiteService
    {
        public WebsiteService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}