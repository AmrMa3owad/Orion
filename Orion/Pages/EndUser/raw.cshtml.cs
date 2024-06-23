using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using Orion.Models;

namespace Orion.Pages.EndUser
{
    public class rawModel : PageModel
    {
        private readonly IMaterialService _materialService;
        private readonly ICartService _cartService;

        public Cart Cart { get; set; }
        public List<Material> Materials { get; set; }
        public IEnumerable<string> MaterialNames { get; set; }
        public IEnumerable<byte[]?> MaterialImg { get; set; }
        public IEnumerable<double?> MaterialPrice { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MaterialType { get; set; }

        public rawModel(IMaterialService materialService, ICartService cartService)
        {
            _materialService = materialService;
            _cartService = cartService;
        }

        public async Task<IActionResult> OnGet()
        {
            var allMaterials = await _materialService.GetAll(new CancellationToken()).ToListAsync();

            if (!string.IsNullOrEmpty(SearchQuery))
            {
                allMaterials = allMaterials.Where(p => p.MaterialName.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(MaterialType))
            {
                allMaterials = allMaterials.Where(p => p.MaterialType.Equals(MaterialType, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            Materials = allMaterials;
            MaterialNames = Materials.Select(x => x.MaterialName);
            MaterialImg = Materials.Select(x => x.Image);
            MaterialPrice = Materials.Select(x => x.MaterialPrice);

            return Page();
        }

        //public async Task<JsonResult> OnPostAddToCartAsync([FromBody] CartProduct cartMaterial)
        //{
        //    var material = await _materialService.Get(cartMaterial.MaterialId, new CancellationToken());

        //    if (!cartMaterial.CartId.HasValue)
        //    {
        //        Cart = new Cart();
        //        Cart = await _cartService.Create(Cart);
        //    }
        //    else
        //    {
        //        Cart = await _cartService.Get(cartMaterial.CartId.Value, new CancellationToken());
        //    }

        //    Cart.Materials.Add(Material);
        //    Cart.NumberOfMaterials = Cart.Materials.Count;
        //    Cart.TotalPrice = Cart.Materials.Sum(p => p.MaterialPrice);
        //    await _cartService.Update(Cart);

        //    return new JsonResult(new { CartId = Cart.Id, Materials = Cart.Materials.Select(p => new { MaterialId = p.Id }).ToList() });
        //}
    }
}