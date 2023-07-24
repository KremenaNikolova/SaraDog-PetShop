namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PetShop.Data.Models;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Infrastructure.Extensions;
    using PetShop.Web.ViewModels.User;
    
    using static PetShop.Common.NotificationMessagesConstants;

    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IImageService imageService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IUserService userService,IImageService imageService, SignInManager<ApplicationUser> signInManager)
        {
            this.userService = userService;
            this.imageService = imageService;
            this.signInManager = signInManager;
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

            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";
                return View(userModel);
            }

            var userId = User.GetId();

            try
            {
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
