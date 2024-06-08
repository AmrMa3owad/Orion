using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.Supervisor
{
    public class AddProductModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public AddProductModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
