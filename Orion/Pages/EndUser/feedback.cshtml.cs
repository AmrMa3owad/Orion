using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Orion.Pages.EndUser
{
    public class feedbackModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        public feedbackModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
