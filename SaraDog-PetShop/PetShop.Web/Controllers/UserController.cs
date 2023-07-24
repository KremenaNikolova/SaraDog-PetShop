namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PetShop.Data.Models;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Infrastructure.Extensions;
    using PetShop.Web.ViewModels.Account;
    using PetShop.Web.ViewModels.User;
    
    using static PetShop.Common.NotificationMessagesConstants;

    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IImageService imageService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IUserService userService,IImageService imageService, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userService = userService;
            this.imageService = imageService;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
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
                if (user.IsDeleted)
                {
                    ModelState.AddModelError(string.Empty, "This account doesn't exist");
                    return View(loginModel);
                }

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

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
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

        [HttpGet]
        public async Task<IActionResult> Details()
        {
            var userId = User.GetId();
            try
            {
                var currUser = await userService.GetUserByIdAsync(userId!);
                return View(currUser);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var userId = User.GetId();

            try
            {
                var editUserModel = await userService.GetUserByIdAsync(userId!);
                return View(editUserModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserProfileViewModel userModel)
        {
            if (userModel.FormImage != null)
            {
                var fileResult = await imageService.SaveImage(userModel.FormImage);
                if (fileResult.Item1 == 1)
                {
                    userModel.Image = fileResult.Item2; // getting name of image
                }
            }

            var userId = User.GetId();
            var user = await userService.GetUserByIdAsync(userId!);

            if (!ModelState.IsValid)
            {
                userModel.UserName = user.UserName;
                userModel.Email = user.Email;

                return View(userModel);
            }

            try
            {
                await imageService.DownloadImageAsync(user.Image!);

                await userService.EditProfileAsync(userId!, userModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }

            TempData[SuccessMessage] = "You edited your profile successfully.";
            return RedirectToAction("Details", "User");
        }

        [HttpPost]
        public async Task<IActionResult> Delete()
        {
            var userId = User.GetId();

            try
            {
                await userService.SoftDeleteUserAsync(userId!);

                await signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        private IActionResult GeneralErrorMessage()
        {
            TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

            return RedirectToAction("Details", "User");
        }
    }
}
