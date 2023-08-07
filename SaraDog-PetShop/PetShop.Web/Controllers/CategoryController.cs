namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Infrastructure.Extensions;
    using static PetShop.Common.NotificationMessagesConstants;

    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IImageService imageService;
        private readonly IItemService itemService;

        public CategoryController(ICategoryService categoryService, IImageService imageService, IItemService itemService)
        {
            this.categoryService = categoryService;
            this.imageService = imageService;
            this.itemService = itemService;

        }

        public async Task<IActionResult> All()
        {
            try
            {
                var allCategories = await categoryService.AllCateagoriesAsync();
                foreach (var category in allCategories)
                {
                    await imageService.DownloadImageAsync(category.Image!);
                }
                return View(allCategories);
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "Something get wrong with visualisation of all Categories! Please try again later.";
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Items(string name)
        {
            try
            {
                var items = await itemService.AllItemsByChoosenCategoryAsync(name);

                foreach (var item in items)
                {
                    await imageService.DownloadImageAsync(item.Image);
                }

                return View(items);
            }
            catch (Exception)
            {
                return GenerealCategoryError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Favourites(int id)
        {
            try
            {
                var userId = User.GetId();

                await itemService.AddToFavouritesAsync(userId!, id);

                var previousUrl = Request.Headers["Referer"].ToString();

                return Redirect(previousUrl);
            }
            catch (Exception)
            {
                return GenerealCategoryError();
            }
        }

        private IActionResult GenerealCategoryError()
        {
            TempData[ErrorMessage] = "Something get wrong! Please try again later";
            return RedirectToAction("All", "Category");
        }

    }
}
