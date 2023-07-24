namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Data.Models;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.ViewModels.Account;

    using static PetShop.Common.NotificationMessagesConstants;

    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IUserService userService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUserService userService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginModel)
        {
            if (!ModelState.IsValid)
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

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }

            var user = await userManager.FindByEmailAsync(registerModel.Email);
            if (user != null)
            {
                TempData[ErrorMessage] = "This email is already registered!";

                return View(registerModel);
            }

            var username = await userManager.FindByNameAsync(registerModel.Username);
            if (username != null)
            {
                TempData[ErrorMessage] = "This Username is already registered!";

                return View(registerModel);
            }

            user = new ApplicationUser();

            await userManager.SetEmailAsync(user, registerModel.Email);
            await userManager.SetUserNameAsync(user, registerModel.Username);

            var result = await userManager.CreateAsync(user, registerModel.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(registerModel);
            }

            //TODO: Add role to the user "userManager.AddToRoleAsync(user, UserRole.ROLE);

            await signInManager.SignInAsync(user, false);

            return RedirectToAction("All", "Item");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
