using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.EndUser
{
    public class rawModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public rawModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
