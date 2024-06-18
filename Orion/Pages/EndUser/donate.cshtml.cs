using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class donateModel : PageModel
    {
        [BindProperty]

        public Donation Donation { get; set; }

        private readonly IDonationService _donationService;

        public donateModel(IDonationService donationService)
        {
            _donationService = donationService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _donationService.Create(Donation);

            return Page();
        }
    }
}
