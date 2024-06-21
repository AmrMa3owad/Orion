using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class addMaterialModel : PageModel
    {
        [BindProperty]

        public Material Material { get; set; }

        private readonly IMaterialService _MaterialService;

        public addMaterialModel(IMaterialService MaterialService)
        {
            _MaterialService = MaterialService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _MaterialService.Create(Material);

            return Page();
        }
    }
}
