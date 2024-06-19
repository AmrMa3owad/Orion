using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Supervisor
{
    public class childProfileModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IFreelancerService _freelancerService;
        private readonly IUserService _userService;

        public childProfileModel(
            IProductService productService,
            IFreelancerService freelancerService,
            IUserService userService)
        {
            _productService = productService;
            _freelancerService = freelancerService;
            _userService = userService;
        }

        public List<Freelancer> Freelancers { get; set; }
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public IEnumerable<int> ProductsNum { get; set; }
        public IEnumerable<string> FreelancerAge { get; set; }
        public IEnumerable<byte[]> FreelancerImg { get; set; }
        public IEnumerable<int> FreelancerId { get; set; }
        public IEnumerable<string?> FreelancerInfo { get; set; }
        public IEnumerable<ICollection<Product?>> FreelancerProduct { get; set; }
        public IEnumerable<string> FreelancerOrphanage { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            Users = await _userService.GetAll(CancellationToken.None).ToListAsync();
            Products = await _productService.GetAll(CancellationToken.None).ToListAsync();
            Freelancers = await _freelancerService.GetAllInclude(CancellationToken.None);

            ProductsNum = Freelancers.Select(x=>x.Products.Count);
            FreelancerAge = Users.Select(x => x.BirthDate);
            FreelancerImg = Freelancers.Select(x => x.StarPhoto);
            FreelancerInfo = Freelancers.Select(x => x.FreelancerDescription);
            FreelancerId = Freelancers.Select(x => x.UserId);
            FreelancerProduct = Freelancers.Select(x => x.Products);
            FreelancerOrphanage = Freelancers.Select(x => x.Orphanage.OrphanageName);
            return Page();
        }
    }
}
