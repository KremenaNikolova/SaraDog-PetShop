using Microsoft.AspNetCore.Mvc;
using PetShop.Services.Data.Interfaces;
using PetShop.Web.ViewModels.Shop;

namespace PetShop.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICategoryService categoryService;

        public ShopController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var itemModel = new ItemFormViewModel()
            {
                Categories = await this.categoryService.AllCteagoriesAsync()
            };

            return View(itemModel);
        }
    }
}
