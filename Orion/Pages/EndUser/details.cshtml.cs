using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class detailsModel : PageModel
    {

        public List<Product> products { get; set; }
        public Product product { get; set; }


        private readonly IProductService _productService;

        public detailsModel(IProductService productService) : base()
        {
            _productService = productService;
        }
        public async Task<IActionResult> OnGet(int Id)
        {
           
            products = await _productService
                .GetAll(new CancellationToken()).ToListAsync();

            product = await _productService.Get( Id, new CancellationToken()); //TODO



            return Page();
        }
    }
}
