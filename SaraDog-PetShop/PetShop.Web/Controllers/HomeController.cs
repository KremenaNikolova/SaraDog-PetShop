namespace PetShop.Web.Controllers
{
    using System.Diagnostics;
    
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;
    using ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IItemService itemService;
        private readonly IImageService imageService;

        public HomeController(IItemService shopService, IImageService imageService)
        {
            this.itemService = shopService;
            this.imageService = imageService;

        }

        public async Task<IActionResult> Index()
        {
            var allItems = await itemService.GetAllItemsAsync();

            return View(allItems);
        }

        public async Task<IActionResult> GetImage(string imageName)
        {
            var imageStream = await imageService.GetImageStreamAsync(imageName);

            if (imageStream == null)
            {
                return NotFound();
            }

            return File(imageStream, "image/jpeg");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}