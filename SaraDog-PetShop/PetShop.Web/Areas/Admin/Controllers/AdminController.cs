namespace PetShop.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Data.Models;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.ViewModels.User;
    using PetShop.Web.ViewModels.Category;
    using PetShop.Web.ViewModels.Item;

    using static PetShop.Common.NotificationMessagesConstants;

    public class AdminController : BaseController
    {
        private readonly IItemService itemService;
        private readonly IUserService userService;
        private readonly ICategoryService categoryService;
        private readonly IImageService imageService;
        private readonly UserManager<ApplicationUser> userManager;

        public AdminController(
            IItemService itemService, 
            IUserService userService, 
            ICategoryService categoryService, 
            IImageService imageService, 
            UserManager<ApplicationUser> userManager)
        {
            this.itemService = itemService;
            this.userService = userService;
            this.categoryService = categoryService;
            this.imageService = imageService;
            this.userManager = userManager;

        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var allCategories = await categoryService.AllCateagoriesAsync();
                var allItems = await itemService.GetAllIActivetemsAsync();
                var allUsers = await userService.GetAllUsersAsync();

                ManagerGroupFormViewModel groupModel = new ManagerGroupFormViewModel()
                {
                    Users = allUsers,
                    Items = allItems,
                    Categories = allCategories,
                };

                return View(groupModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        public async Task<IActionResult> Items([FromQuery] AllItemsQueryModel queryModel)
        {
            try
            {
                var allProducts = await itemService.AllIVisibletemsQueryAsync(queryModel);

                queryModel.Items = allProducts.Items;
                queryModel.TotalItems = allProducts.TotalItemsCount;
                queryModel.Categories = await categoryService.AllCategoriesNameAsync();

                foreach (var item in allProducts.Items)
                {
                    await imageService.DownloadImageAsync(item.Image);
                }

                return View(queryModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        public async Task<IActionResult> Categories([FromQuery] AllCategoriesQueryModel queryModel)
        {
            try
            {
                var allCategories = await categoryService.AllCategoriesQueryAsync(queryModel);

                queryModel.Categories = allCategories.Categories;
                queryModel.TotalCategories = allCategories.TotalCategoriesCount;

                foreach (var category in allCategories.Categories)
                {
                    await imageService.DownloadImageAsync(category.Image!);
                }

                return View(queryModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        public async Task<IActionResult> Users([FromQuery] AllUsersQueryModel queryModel)
        {
            try
            {
                var allUsers = await userService.AllUsersQueryAsync(queryModel);

                queryModel.Users = allUsers.Users;
                queryModel.TotalUsers = allUsers.TotalUsersCount;

                return View(queryModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        [HttpPost]
        public async Task<IActionResult> SetRole(string userId, bool isModerator)
        {
            var user = await userManager.FindByIdAsync(userId);
            var roles = await userManager.GetRolesAsync(user);
            bool isChecked = roles.Any(r => r.Contains("Moderator"));

            try
            {
                if (!isChecked)
                {
                    await userManager.AddToRoleAsync(user, "Moderator");
                }
                else if (isChecked)
                {
                    await userManager.RemoveFromRoleAsync(user, "Moderator");
                }

                await userService.ReverseIsModeratorAsync(userId);

                var previousUrl = Request.Headers["Referer"].ToString();

                return Redirect(previousUrl);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Enable(int id)
        {
            try
            {
                await itemService.TurnActivityAsync(id);
                ItemFormViewModel currItem = await itemService.GetItemByIdAsync(id);

                TempData[SuccessMessage] = currItem.IsActive ? "You Deactivated the product successfully." : "You Actived the product successfully.";

                var previousUrl = Request.Headers["Referer"].ToString();

                return Redirect(previousUrl);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        private IActionResult GeneralErrorMessage()
        {
            TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

            var previousUrl = Request.Headers["Referer"].ToString();

            return Redirect(previousUrl);
        }
    }
}
