using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.EndUser
{
    public class detailsModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public detailsModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
