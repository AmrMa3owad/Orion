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
        public List<Role> Roles;
            public void OnGet()
            {
           
                Roles = new List<Role>();
                Roles = _context.Roles
                    .ToList();
            }
    }
}

