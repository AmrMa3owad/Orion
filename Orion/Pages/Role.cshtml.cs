using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Models;
using Orion.Context;

namespace Orion.Pages
{
    public class RoleModel : PageModel
    {
        private readonly AppDbContext _context;

        public RoleModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Role> Roles { get; set; }

        public void OnGet()
        {
            Roles = _context.Roles.ToList();
        }
    }
}

