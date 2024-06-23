using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class detailsModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IFeedbackService _feedbackService;
        public Product Product { get; set; }
        public List<Feedback> Feedbacks { get; set; }
        [BindProperty]

        public Feedback Feedback { get; set; }

        [BindProperty(SupportsGet = true)]
        public int ProductId { get; set; }
        public IEnumerable<string> Mail { get; set; }
        public IEnumerable<string> Msg { get; set; }

        public detailsModel(IProductService productService, IFeedbackService feedbackService)
        {
            _productService = productService;
            _feedbackService = feedbackService;
        }

        public async Task<IActionResult> OnGetAsync()
        {          

            Product = await _productService.Get(productId, new CancellationToken());
            Feedbacks = await _feedbackService.GetAll(new CancellationToken()).ToListAsync();          

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {

            await _feedbackService.Create(Feedback);
            Feedback.ProductId = ProductId;

            var freelancer = await _productService.Get(ProductId, new System.Threading.CancellationToken());
            if (freelancer != null)
            {
                freelancer.Feedbacks.Add(Feedback);
                await _productService.Update(freelancer);
            }

            return Page();
        }

    }
}
