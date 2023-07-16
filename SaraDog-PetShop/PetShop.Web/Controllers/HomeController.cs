namespace PetShop.Web.Controllers
{
    using System.Diagnostics;
    
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.Home;
    using PetShop.Services.Data.Interfaces;

    using static PetShop.Common.NotificationMessagesConstants;

    public class HomeController : Controller
    {
        private readonly IItemService itemService;
        private readonly IImageService imageService;

        public HomeController(IItemService shopService, IImageService imageService)
        {
            this.itemService = shopService;
            this.imageService = imageService;

        }

        public IActionResult Index()
        {
            var landingImage = imageService
                .GetLandingPageImageAsync();

            return View(landingImage);
        }

        public async Task<IActionResult> GetImage(string imageName)
        {
            try
            {
                var imageStream = await imageService.GetImageStreamAsync(imageName);

                return File(imageStream, "image/jpeg");
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "Something get wrong with taken image. Please try again later!";

                return RedirectToAction("All", "Item");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}