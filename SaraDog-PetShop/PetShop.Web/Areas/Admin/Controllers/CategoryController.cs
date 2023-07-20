namespace PetShop.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.ViewModels.Category;

    using static PetShop.Common.NotificationMessagesConstants;

    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;
        private readonly IImageService imageService;

        public CategoryController(ICategoryService categoryService, IImageService imageService)
        {
            this.categoryService = categoryService;
            this.imageService = imageService;

        }


        [HttpGet]
        public IActionResult Add()
        {
            try
            {
                var cateogryModel = new NewCategoryViewModel();

                return View(cateogryModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(NewCategoryViewModel categoryModel)
        {
            bool isCategoryExist = await categoryService
                .IsCategoryExistByNameAsync(categoryModel.Name);

            if (isCategoryExist)
            {
                ModelState.AddModelError(nameof(categoryModel.Name), "This Category already exist");
            }

            if (categoryModel.ImageFile != null)
            {
                var fileResult = await imageService.SaveImage(categoryModel.ImageFile);
                if (fileResult.Item1 == 1)
                {
                    categoryModel.Image = fileResult.Item2; // getting name of image
                }
            }

            if (categoryModel.Image != null)
            {
                ModelState.Remove("Image");
            }

            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(categoryModel.Image))
            {
                TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

                return View(categoryModel);
            }

            try
            {
                await categoryService.CreateNewCategoryAsync(categoryModel);
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

                return View(categoryModel);
            }

            TempData[SuccessMessage] = "Your new category have been added successfully.";
            return RedirectToAction("Items", "Admin");
        }

        private IActionResult GeneralErrorMessage()
        {
            TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

            return RedirectToAction("Items", "Admin");
        }
    }
}
