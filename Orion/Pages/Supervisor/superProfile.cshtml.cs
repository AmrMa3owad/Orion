using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Pages.Supervisor
{
    public class superProfileModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IFreelancerService _freelancerService;
        private readonly ISupervisorService _supervisorService;
        private readonly IUserService _userService;

        public superProfileModel(
            IProductService productService,
            IFreelancerService freelancerService,
            ISupervisorService supervisorService,
            IUserService userService)
        {
            _productService = productService;
            _freelancerService = freelancerService;
            _supervisorService = supervisorService;
            _userService = userService;
        }

        [BindProperty(SupportsGet = true)]
        public List<Domain.Models.Supervisor> Supervisors { get; set; }

        public List<Freelancer> Freelancers { get; set; }
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public IEnumerable<int> ProductsNum { get; set; }
        public IEnumerable<int> FreelancerNum { get; set; }
        public IEnumerable<int> SupervisorId { get; set; }
        public IEnumerable<byte[]?> SupervisorImg { get; set; }
        public IEnumerable<string?> SupervisorInfo { get; set; }
        public IEnumerable<ICollection<Freelancer?>> SupervisorFreelancer { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Users = await _userService.GetAll(CancellationToken.None).ToListAsync();
            Products = await _productService.GetAll(CancellationToken.None).ToListAsync();
            Freelancers = await _freelancerService.GetAll(CancellationToken.None).ToListAsync();
            Supervisors = await _supervisorService.GetAll(CancellationToken.None).ToListAsync();

            ProductsNum = Supervisors.Select(x => x.Products.Count);
            FreelancerNum = Supervisors.Select(x => x.Freelancers.Count);
            SupervisorImg = Supervisors.Select(x => x.SupervisorPhoto);
            SupervisorInfo = Supervisors.Select(x => x.SupervisorInfo);
            SupervisorId = Supervisors.Select(x => x.EmployeeId);

            SupervisorFreelancer = Supervisors.Select(x => x.Freelancers);
            return Page();
        }
    }
}
