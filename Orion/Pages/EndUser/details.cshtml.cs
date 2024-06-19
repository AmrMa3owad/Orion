using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class detailsModel : PageModel
    {
        private readonly IProductService _productService;
        public Product Product { get; set; }

        [BindProperty(SupportsGet = true)]
        public int ProductId { get; set; }

        public detailsModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> OnGetAsync()
        {          

            Product = await _productService.Get(ProductId, new CancellationToken());          

            return Page();
        }
    }
}
