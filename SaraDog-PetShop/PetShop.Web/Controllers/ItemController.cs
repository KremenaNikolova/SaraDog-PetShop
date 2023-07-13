namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.ViewModels.Item;

    using static PetShop.Common.CustomExceptionsMessages;

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
            var allItems = await itemService.AllItemsAsync(queryModel);

            queryModel.Items = allItems.Items;
            queryModel.TotalItems = allItems.TotalItemsCount;
            queryModel.Categories = await categoryService.AllCategoriesNameAsync();

            return View(queryModel);
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

        [HttpPost]
        public async Task<IActionResult> Add(ItemFormViewModel itemModel)
        {
            bool isCategoryExist = await categoryService
                .IsCategoryExistAsync(itemModel.CategoryId);

            if (!isCategoryExist)
            {
                ModelState.AddModelError(nameof(itemModel.CategoryId), "Invalid Category");
            }

            if(itemModel.ImageFile != null)
            {
                var fileResult = await imageService.SaveImage(itemModel.ImageFile);
                if (fileResult.Item1 == 1)
                {
                    itemModel.UploadPicture = fileResult.Item2; // getting name of image
                }
            }

            if (itemModel.UploadPicture != null)
            {
                ModelState.Remove("UploadPicture");
            }

            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(itemModel.UploadPicture))
            {
                itemModel.Categories = await categoryService.AllCteagoriesAsync();

                return View(itemModel);
            }

            try
            {
                await itemService.CreateItemAsync(itemModel);
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred! Please, try again.");

                return View(itemModel);
            }

            return RedirectToAction("All", "Item");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var cuurrItem = await itemService.GetItemByIdAsync(id);

            if (cuurrItem == null)
            {
                return RedirectToAction("All", "Item");
            }

            return View(cuurrItem);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ItemFormViewModel itemModel)
        {
            itemModel.Categories = await categoryService.AllCteagoriesAsync();

            bool isCategoryExist = await categoryService
                .IsCategoryExistAsync(itemModel.CategoryId);

            if (!isCategoryExist)
            {
                ModelState.AddModelError(nameof(itemModel.CategoryId), "Invalid Category");
            }

            if (itemModel.ImageFile != null)
            {
                var fileResult = await imageService.SaveImage(itemModel.ImageFile);
                if (fileResult.Item1 == 1)
                {
                    itemModel.UploadPicture = fileResult.Item2; // getting name of image
                }
            }
 
            if (!ModelState.IsValid)
            {
                itemModel.Categories = await categoryService.AllCteagoriesAsync();

                return View(itemModel);
            }

            try
            {
                await itemService.EditProductAsync(id, itemModel);
            }
            catch
            {
               ModelState.AddModelError(string.Empty, "An unexpected error occurred! Please, try again.");

                return View(itemModel);
            }

            return RedirectToAction("All", "Item");
        }
    }
}
