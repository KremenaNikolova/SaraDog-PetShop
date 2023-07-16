namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.ViewModels.ApplicationUser;
    using PetShop.Web.ViewModels.Item;
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

        public async Task<IActionResult> Items([FromQuery]AllItemsQueryModel queryModel)
        {
            try
            {
                var allProducts = await itemService.AllIVisibletemsQueryAsync(queryModel);

                queryModel.Items = allProducts.Items;
                queryModel.TotalItems = allProducts.TotalItemsCount;
                queryModel.Categories = await categoryService.AllCategoriesNameAsync();

                return View(queryModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        private IActionResult GeneralErrorMessage()
        {
            TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

            return RedirectToAction("Index", "Admin");
        }
    }
}
