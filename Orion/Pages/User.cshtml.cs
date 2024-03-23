using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Context;
using Orion.Controllers;
using Orion.Models;

namespace Orion.Pages
{
    public class UserModel : PageModel
    {
        private readonly UserController _userController;
        public UserModel(UserController userController)
        {
            _userController = userController;
        }

        public List<User> Users;
        public void OnGet()
        {
           Users = (List<User>)_userController.Get();
        }
    }
}