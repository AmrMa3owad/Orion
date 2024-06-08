using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.Supervisor
{
    public class superProfileModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public superProfileModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
