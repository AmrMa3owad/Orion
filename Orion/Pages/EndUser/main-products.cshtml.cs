using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class mainproductsModel : PageModel
    {
        public List<Product> Products { get; set; }
        public IEnumerable<string> ProNames { get; set; }
        public IEnumerable<byte[]?> ProductImg { get; set; }
        public IEnumerable<int> ProductPrice { get; set; }

        private readonly IProductService _productService;

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ProductType { get; set; }

        public mainproductsModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> OnGet()
        {
            var allProducts = await _productService.GetAll(new CancellationToken()).ToListAsync();

            if (!string.IsNullOrEmpty(SearchQuery))
            {
                allProducts = allProducts.Where(p => p.ProductName.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(ProductType))
            {
                allProducts = allProducts.Where(p => p.ProductType.Equals(ProductType, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            Products = allProducts;
            ProNames = Products.Select(x => x.ProductName);
            ProductImg = Products.Select(x => x.ProductImage);
            ProductPrice = Products.Select(x => x.ProductPrice);

            return Page();
        }
    }
}
