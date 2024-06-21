using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class supertableModel : PageModel
    {
        private readonly ISupervisorService _supervisorService;

        public List<Domain.Models.Supervisor> Supervisors { get; set; }

        public supertableModel(ISupervisorService supervisorService)
        {
            _supervisorService = supervisorService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Supervisors = await _supervisorService.GetAllInclude(new CancellationToken());
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var supervisor = await _supervisorService.Get(id, new CancellationToken());

            await _supervisorService.Delete(supervisor);

            return RedirectToPage();
        }
    }
}
