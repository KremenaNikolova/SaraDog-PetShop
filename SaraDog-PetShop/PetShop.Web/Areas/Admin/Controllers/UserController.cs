namespace PetShop.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PetShop.Common;
    using PetShop.Data.Models;
    using PetShop.Services.Data;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Infrastructure.Extensions;

    using static PetShop.Common.NotificationMessagesConstants;

    public class UserController : BaseController
    {
        private readonly IUserService userService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IUserService userService, SignInManager<ApplicationUser> signInManager)
        {
            this.userService = userService;
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                await userService.SoftDeleteUserAsync(id);

                await signInManager.SignOutAsync();
                var previousUrl = Request.Headers["Referer"].ToString();

                return Redirect(previousUrl);
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

                var previousUrl = Request.Headers["Referer"].ToString();

                return Redirect(previousUrl);
            }
        }
    }
}
