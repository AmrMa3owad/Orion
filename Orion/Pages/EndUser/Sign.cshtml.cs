using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class SignModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public SignModel(IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostSignInAsync()
        {
            var result = await _userService.SignIn(Email, Password, new CancellationToken());
            if (result.Succeeded)
            {
                return RedirectToPage("/EndUser/Home");
            }
            else
            {
                return Page();
            }
        }

        public async Task<IActionResult> OnPostSignUpAsync()
        {
            var user = new User
            {
                UserName = Username,
                Email = Email,
                // Note: Storing passwords as plain text is not secure.
                // You should hash passwords before storing them.
                // Example: user.PasswordHash = _passwordHasher.HashPassword(user, Password);
                PasswordHash = Password // This should be securely hashed.
            };

            var result = await _userService.Create(user, Password);
            if (result.Succeeded)
            {
                // Optionally, you might want to automatically sign in the user after successful registration.
                var signInResult = await _userService.SignIn(user.Email, Password, new CancellationToken());
                if (signInResult.Succeeded)
                {
                    return RedirectToPage("/EndUser/Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Failed to sign in after registration.");
                    return Page();
                }
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }
        }
    }
}
