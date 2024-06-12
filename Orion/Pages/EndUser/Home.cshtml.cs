using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class HomeModel : PageModel
    {
        public List<Orphanage> orphanages { get; set; }
        public int orphanagesNum { get; set; }


        private readonly IOrphanageService _orphanageService;
        public HomeModel(IOrphanageService orphanageService) : base()
        {
            _orphanageService = orphanageService;
        }
        public async Task<IActionResult> OnGet()
        {
            orphanages = await _orphanageService
                .GetAll(new CancellationToken()).ToListAsync();

             orphanagesNum = orphanages.Count;

            return Page();
        }
    }
}
