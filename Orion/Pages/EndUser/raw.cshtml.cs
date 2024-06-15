using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class rawModel : PageModel
    {
        public List<Product> products { get; set; }
        public IEnumerable<string> ProName { get; set; }

        private readonly IProductService _productService;

        public rawModel(IProductService productService) : base()
        {
            _productService = productService;

        }
        public async Task<IActionResult> OnGet()
        {

            products = await _productService
                .GetAll(new CancellationToken()).ToListAsync();

            ProName = products.Select(x=>x.ProductName); // TODO
            return Page();
        }

    }
}