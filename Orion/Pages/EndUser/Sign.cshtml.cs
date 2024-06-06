using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.EndUser
{
    public class SignModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public SignModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
