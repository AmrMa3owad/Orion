using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.IO;
using System.Threading.Tasks;

namespace Orion.Pages.Admin
{
    public class AddSuperModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        [BindProperty]
        public Domain.Models.Supervisor Supervisor { get; set; }

        [BindProperty]
        public IFormFile SupervisorImageFile { get; set; }

        private readonly IUserService _userService;
        private readonly ISupervisorService _supervisorService;

        public AddSuperModel(IUserService userService, ISupervisorService supervisorService)
        {
            _userService = userService;
            _supervisorService = supervisorService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _userService.Create(User);

            Supervisor.EmployeeId = User.Id;

            if (SupervisorImageFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await SupervisorImageFile.CopyToAsync(memoryStream);
                    Supervisor.SupervisorPhoto = memoryStream.ToArray();
                }
            }

            await _supervisorService.Create(Supervisor);

            return RedirectToPage("/Admin/Dashboard");
        }
    }
}
