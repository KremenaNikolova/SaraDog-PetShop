using Microsoft.AspNetCore.Mvc;
using PetShop.Services.Data.Interfaces;
using PetShop.Web.ViewModels.Item;

namespace PetShop.Web.Controllers
{
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
                ModelState.AddModelError(nameof(itemModel.CategoryId), "Посочената категория е невалидна.");
            }

            if(itemModel.ImageFile != null)
            {
                var fileResult = await imageService.SaveImage(itemModel.ImageFile);
                if (fileResult.Item1 == 1)
                {
                    itemModel.UploadPicture = fileResult.Item2; // getting name of image
                }
            }

            ModelState.Remove("UploadPicture");

            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(itemModel.UploadPicture))
            {
                itemModel.Categories = await this.categoryService.AllCteagoriesAsync();

                return View(itemModel);
            }

            try
            {
                await this.itemService.CreateItemAsync(itemModel);
            }
            catch
            {
                this.ModelState.AddModelError(string.Empty, "Възникна неочаквана грешка! Моля, опитайте отново.");

                return this.View(itemModel);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
