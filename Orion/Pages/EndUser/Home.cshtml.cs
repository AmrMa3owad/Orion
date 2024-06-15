using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class HomeModel : PageModel
    {
        public List<Freelancer> freelancers { get; set; }
        public List<Product> products { get; set; }
        public List<Orphanage> orphanages { get; set; }
        public int orphanagesNum { get; set; }
        public int productsNum { get; set; }
        public int freelancerNum { get; set; }


        private readonly IOrphanageService _orphanageService;
        private readonly IProductService _productService;
        private readonly IFreelancerService _freelancerService;

        public HomeModel(IOrphanageService orphanageService,
            IProductService productService,
            IFreelancerService freelancerService) : base()
        {
            _orphanageService = orphanageService;
            _productService = productService;
            _freelancerService = freelancerService;

        }
        public async Task<IActionResult> OnGet()
        {
            orphanages = await _orphanageService
                .GetAll(new CancellationToken()).ToListAsync();
            products = await _productService
                .GetAll(new CancellationToken()).ToListAsync();
            freelancers = await _freelancerService
               .GetAll(new CancellationToken()).ToListAsync();

            orphanagesNum = orphanages.Count;
            productsNum = products.Count;
            freelancerNum = freelancers.Count;


            return Page();
        }
    }
}
