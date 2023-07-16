namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.ViewModels.ApplicationUser;
    using static PetShop.Common.NotificationMessagesConstants;

    public class AdminController : Controller
    {
        private readonly IItemService itemService;
        private readonly IUserService userService;
        private readonly ICategoryService categoryService;

        public AdminController(IItemService itemService, IUserService userService, ICategoryService categoryService)
        {
            this.itemService = itemService;
            this.userService = userService;
            this.categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var allCategories = await categoryService.AllCteagoriesAsync();
                var allItems = await itemService.GetAllItemsAsync();
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
                TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

                return RedirectToAction("All", "Item");
            }
        }
    }
}
