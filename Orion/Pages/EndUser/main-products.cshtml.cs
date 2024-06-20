using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using Orion.Models;

namespace Orion.Pages.EndUser
{
    public class mainproductsModel : PageModel
    {
        public Cart Cart { get; set; }
        public List<Product> Products { get; set; }
        public IEnumerable<string> ProNames { get; set; }
        public IEnumerable<byte[]?> ProductImg { get; set; }
        public IEnumerable<double?> ProductPrice { get; set; }

        private readonly IProductService _productService;
        private readonly ICartService _cartService;

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ProductType { get; set; }

        public mainproductsModel(IProductService productService, ICartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
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
        public async Task<JsonResult> OnPostAddToCartAsync([FromBody] CartProduct cartProduct)
        {
            var product = await _productService.Get(cartProduct.ProductId, new CancellationToken());

            if (!cartProduct.CartId.HasValue)
            {
                Cart = new Cart();
                Cart = await _cartService.Create(Cart);
            }
            else
            {
                Cart = await _cartService.Get(cartProduct.CartId.Value, new CancellationToken());
            }

            Cart.Products.Add(product);
            Cart.NumberOfProducts = Cart.Products.Count;
            Cart.TotalPrice = Cart.Products.Sum(p => p.ProductPrice);
            await _cartService.Update(Cart);

            return new JsonResult(new { CartId = Cart.Id, Products = Cart.Products.Select(p => new { ProductId = p.Id }).ToList() });
        }
    }
}
