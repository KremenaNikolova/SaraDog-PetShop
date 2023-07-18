namespace PetShop.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.ViewModels.Item;

    using static PetShop.Common.NotificationMessagesConstants;

    public class ItemController : BaseController
    {
        private readonly IItemService itemService;
        private readonly ICategoryService categoryService;
        private readonly IImageService imageService;

        public ItemController(IItemService itemService, ICategoryService categoryService, IImageService imageService)
        {
            this.itemService = itemService;
            this.categoryService = categoryService;
            this.imageService = imageService;

        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            try
            {
                var itemModel = new ItemFormViewModel()
                {
                    Categories = await this.categoryService.AllCteagoriesAsync()
                };

                return View(itemModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }

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

            if (itemModel.ImageFile != null)
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

                TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

                return View(itemModel);
            }

            try
            {
                await itemService.CreateItemAsync(itemModel);
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

                return View(itemModel);
            }

            TempData[SuccessMessage] = "Your product have been added successfully.";
            return RedirectToAction("All", "Item");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var cuurrItem = await itemService.GetItemByIdAsync(id);
                return View(cuurrItem);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ItemFormViewModel itemModel)
        {
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
                TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";
                return View(itemModel);
            }

            try
            {
                await itemService.EditProductAsync(id, itemModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }

            TempData[SuccessMessage] = "You edited the product successfully.";
            return RedirectToAction("Items", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await itemService.SoftDeleteItemAsync(id);
                TempData[SuccessMessage] = "You deleted the product successfully.";
                return RedirectToAction("Items", "Admin");
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        private IActionResult GeneralErrorMessage()
        {
            TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

            return RedirectToAction("Items", "Admin");
        }
    }
}
