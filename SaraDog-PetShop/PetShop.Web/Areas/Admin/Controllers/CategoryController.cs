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
            return RedirectToAction("Categories", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var currCategory = await categoryService.GetCategoryByIdAsync(id);
                return View(currCategory);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewCategoryViewModel categoryModel)
        {
            if (categoryModel.ImageFile != null)
            {
                var fileResult = await imageService.SaveImage(categoryModel.ImageFile);
                if (fileResult.Item1 == 1)
                {
                    categoryModel.Image = fileResult.Item2; // getting name of image
                }
            }

            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(categoryModel.Image))
            {
                TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

                return View(categoryModel);
            }

            try
            {
                await categoryService.EditCategoryAsync(id, categoryModel);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }

            TempData[SuccessMessage] = "You edited the category successfully.";
            return RedirectToAction("Categories", "Admin");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await categoryService.SoftDeleteCategoryAsync(id);
                TempData[SuccessMessage] = "You deleted category successfully.";
                return RedirectToAction("Categories", "Admin");
            }
            catch(Exception)
            {
                return GeneralErrorMessage();
            }
        }

        private IActionResult GeneralErrorMessage()
        {
            TempData[ErrorMessage] = "An unexpected error occurred! Please, try again.";

            return RedirectToAction("Categories", "Admin");
        }
    }
}
