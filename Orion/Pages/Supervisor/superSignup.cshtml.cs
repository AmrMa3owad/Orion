using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.Supervisor
{
    public class superSignupModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public superSignupModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
