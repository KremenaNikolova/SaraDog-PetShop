namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;

    using static PetShop.Common.NotificationMessagesConstants;

    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IImageService imageService;

        public CategoryController(ICategoryService categoryService, IImageService imageService)
        {
            this.categoryService = categoryService;
            this.imageService = imageService;

        }

        public async Task<IActionResult> All()
        {
            try
            {
                var allCategories = await categoryService.AllCteagoriesAsync();
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

    }
}
