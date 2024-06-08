using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.Supervisor
{
    public class editProModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public editProModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
