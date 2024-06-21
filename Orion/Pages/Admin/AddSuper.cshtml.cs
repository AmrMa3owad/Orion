using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class AddSuperModel : PageModel
    {
        [BindProperty]

        public User User { get; set; }
        public Orion.Domain.Models.Supervisor Supervisor { get; set; }

        private readonly IUserService _UserService;
        private readonly ISupervisorService _SupervisorService;

        public AddSuperModel(IUserService UserService, ISupervisorService supervisorService)
        {
            _UserService = UserService;
            _SupervisorService = supervisorService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _UserService.Create(User);
            await _SupervisorService.Create(Supervisor);

            return Page();
        }
    }
}
