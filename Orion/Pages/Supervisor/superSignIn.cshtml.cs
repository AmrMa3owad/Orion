using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.Supervisor
{
    public class superSignInodel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public superSignInModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
