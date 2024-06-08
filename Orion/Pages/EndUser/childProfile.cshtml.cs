using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.EndUser
{
    public class childProfileModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public childProfileModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
