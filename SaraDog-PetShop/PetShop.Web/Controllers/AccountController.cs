namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    
    using PetShop.Data.Models;
    using PetShop.Web.ViewModels.Account;

    using static PetShop.Common.NotificationMessagesConstants;

    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginModel)
        {
            if(!ModelState.IsValid)
            {
                return View(loginModel);
            }

            var user = await userManager.FindByEmailAsync(loginModel.Email);
            if (user != null)
            {
                var isValidPassword = await userManager.CheckPasswordAsync(user, loginModel.Password);

                if (isValidPassword)
                {
                    var result = await signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("All", "Item");
                    }
                }
            }

            TempData[ErrorMessage] = "Incorect Email or Password! Please  try again.";
            return View(loginModel);
        }
    }
}
