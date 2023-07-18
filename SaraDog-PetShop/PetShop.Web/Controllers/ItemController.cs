namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Infrastructure.Extensions;
    using PetShop.Web.ViewModels.Item;

    using static PetShop.Common.NotificationMessagesConstants;

    [Authorize]
    public class ItemController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IItemService itemService;
        private readonly IImageService imageService;

        public ItemController(ICategoryService categoryService, IItemService itemService, IImageService imageService)
        {
            this.categoryService = categoryService;
            this.itemService = itemService;
            this.imageService = imageService;

        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllItemsQueryModel queryModel)
        {
            try
            {
                var allItems = await itemService.AllActiveItemsQueryAsync(queryModel);

                queryModel.Items = allItems.Items;
                queryModel.TotalItems = allItems.TotalItemsCount;
                queryModel.Categories = await categoryService.AllCategoriesNameAsync();

                foreach(var item in allItems.Items)
                {
                    await imageService.DownloadImageAsync(item.Image);
                }

                return View(queryModel);
            }
            catch(Exception)
            {
                return RedirectToAction("Index", "Home");
            }
                
            
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var itemModel = await itemService.GetDetailsByIdAsync(id);
                await imageService.DownloadImageAsync(itemModel.Image);

                return View(itemModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
            
        }


        [HttpGet]
        public async Task<IActionResult> Favourites()
        {
            try
            {
                string userId = this.User.GetId()!;

                var favorites = await itemService.GetAllItemsInFavoritesAsync(userId);
                foreach (var item in favorites)
                {
                    await imageService.DownloadImageAsync(item.Image);
                }

                return View(favorites);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Favourites(int id)
        {
            try
            {
                var userId = User.GetId();

                await itemService.AddToFavouritesAsync(userId!, id);

                return RedirectToAction("All", "Item");
            }
            catch(Exception)
            {
                return GeneralErrorMessage();
            }
        }

        private IActionResult GeneralErrorMessage()
        {
            TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

            return RedirectToAction("All", "Item");
        }

    }

    
}
