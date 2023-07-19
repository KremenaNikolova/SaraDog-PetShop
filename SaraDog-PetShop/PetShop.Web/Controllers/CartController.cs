namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Infrastructure.Extensions;

    using static PetShop.Common.NotificationMessagesConstants;

    public class CartController : Controller
    {
        private readonly ICartService cartService;

        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> Cart()
        {
            try
            {
                var userId = User.GetId();

                var cart = await cartService.GetCartByUserIdAsync(userId!);

                return View(cart);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(int id)
        {
            try
            {
                var userId = User.GetId();

                var cart = await cartService.GetCartByUserIdAsync(userId!);

                if (cart == null)
                {
                    await cartService.CreateCartAsync(userId!);

                    cart = await cartService.GetCartByUserIdAsync(userId!);
                }

                var cartId = cart!.Id;

                await cartService.AddItemToCartAsync(id, cartId, userId!);

                return RedirectToAction("Cart", "Cart");
            }
            catch (Exception)
            {
                GeneralErrorMessage();
            }

            return RedirectToAction("Cart", "Cart");
        }

        private IActionResult GeneralErrorMessage()
        {
            TempData[ErrorMessage] = "An unexpected error occurred with cart! Please, try again.";

            return RedirectToAction("All", "Item");
        }
    }
}
