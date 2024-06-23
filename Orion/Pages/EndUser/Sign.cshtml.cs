using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class SignModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly ICustomerService _customerService;

        public Customer Customer { get; set; }
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public SignModel(IUserService userService, ICustomerService customerService)
        {
            _userService = userService;
            _customerService = customerService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostSignInAsync()
        {
            var result = await _userService.SignIn(Email, Password, new CancellationToken());
            if (result.Succeeded)
            {
                var user = await _userService.GetByEmail(Email, new CancellationToken());
                if (user != null)
                {
                    HttpContext.Session.SetInt32("CustomerID", user.Id);
                    return RedirectToPage("/EndUser/Home");
                }
            }          
              return Page();           
        }

        public async Task<IActionResult> OnPostSignUpAsync()
        {
            var user = new User
            {
                UserName = Username,
                Email = Email,
                PasswordHash = Password 
            };

            var result = await _userService.Create(user, Password);
            var customer = new Customer
            {
                UserId = user.Id
            };
            Customer = await _customerService.Create(customer);

            if (result.Succeeded)
            {
                var signInResult = await _userService.SignIn(user.Email, Password, new CancellationToken());
                if (signInResult.Succeeded)
                {
                    return Page();
                }               
            }
            return Page();
        }
    }
}
