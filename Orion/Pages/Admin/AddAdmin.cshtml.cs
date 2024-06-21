using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class AddAdminModel : PageModel
    {
        [BindProperty]

        public User User { get; set; }
        public Domain.Models.Admin Admin { get; set; }

        private readonly IUserService _UserService;
        private readonly IAdminService _AdminService;

        public AddAdminModel(IUserService UserService, IAdminService AdminService)
        {
            _UserService = UserService;
            _AdminService = AdminService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _UserService.Create(User);
            await _AdminService.Create(Admin);

            return Page();
        }
    }
}
