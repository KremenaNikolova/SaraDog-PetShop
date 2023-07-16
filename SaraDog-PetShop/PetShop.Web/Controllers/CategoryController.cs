namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetShop.Services.Data.Interfaces;

    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IActionResult> All()
        {
            var allCategories = await categoryService.AllCteagoriesAsync();

            return View(allCategories);
        }
    }
}
