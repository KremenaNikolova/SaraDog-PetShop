namespace PetShop.Web.Controllers
{
    using System.Diagnostics;
    
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.Home;
    using PetShop.Services.Data.Interfaces;

    using static PetShop.Common.NotificationMessagesConstants;

    public class HomeController : Controller
    {
        private readonly IImageService imageService;

        public HomeController(IImageService imageService)
        {
            this.imageService = imageService;

        }

        public async Task<IActionResult> Index()
        {
            var landingImage = imageService
                .GetLandingPageImage();

            await imageService.DownloadImageAsync(landingImage.LandingImage);

            return View(landingImage);
        }

        /// <summary>
        /// This Action is for directly using pictures from Azure Storage for view pages as src="@Url.Action("GetImage", "Home", new { imageName = Model.Image })"
        /// At this moment we are downaloding all pictures and use it localy because no money for proper acount :D
        /// </summary>
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

        public async Task<IActionResult> Error(int statusCode)
        {
            if (statusCode == 400)
            {
                var imgName = "error400.jpg";
                await imageService.DownloadImageAsync(imgName);

                return View("Error400");
            }
            else if (statusCode == 401)
            {
                var imgName = "error401.jpg";
                await imageService.DownloadImageAsync(imgName);

                return View("Error401");
            }
            else if (statusCode == 404)
            {
                var imgName = "error404.png";
                await imageService.DownloadImageAsync(imgName);

                return View("Error404");
            }
            else if (statusCode == 500)
            {
                var imgName = "error500.jpg";
                await imageService.DownloadImageAsync(imgName);

                return View("Error500");
            }

            return View("Error");
        }
    }
}