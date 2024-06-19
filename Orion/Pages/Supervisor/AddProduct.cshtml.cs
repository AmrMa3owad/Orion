using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Orion.Pages.Supervisor
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public IFormFile ProductImageFile { get; set; }

        private readonly IProductService _productService;

        public AddProductModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ProductImageFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await ProductImageFile.CopyToAsync(memoryStream);
                    Product.ProductImage = memoryStream.ToArray();
                }
            }

            await _productService.Create(Product);

            return RedirectToPage("/Supervisor/childsProfile"); 
        }
    }
}
