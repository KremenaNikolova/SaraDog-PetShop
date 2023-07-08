namespace PetShop.Web.Controllers
{
    using System.Diagnostics;
    
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;
    using ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IShopService shopService;

        public HomeController(IShopService shopService)
        {
            this.shopService = shopService;
        }

        public async Task<IActionResult> Index()
        {
            var allItems = await shopService.GetAllItemsAsync();

            return View(allItems);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}