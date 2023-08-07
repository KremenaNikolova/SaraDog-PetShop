namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Infrastructure.Extensions;

    using static PetShop.Common.NotificationMessagesConstants;

    [Authorize]
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

                var cart = await cartService.GetCurrCartByUserIdAsync(userId!);

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

                var cart = await cartService.GetCurrCartByUserIdAsync(userId!);

                if (cart == null)
                {
                    await cartService.CreateCartAsync(userId!);

                    cart = await cartService.GetCurrCartByUserIdAsync(userId!);
                }

                var cartId = cart!.Id;

                await cartService.AddItemToCartAsync(id, cartId, userId!);

                var previousUrl = Request.Headers["Referer"].ToString();

                return Redirect(previousUrl);
            }
            catch (Exception)
            {
                return GeneralErrorMessage();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                var userId = User.GetId();

                var cart = await cartService.GetCurrCartByUserIdAsync(userId!);

                await cartService.RemoveItemFromCartAsync(id, cart!.Id);

                TempData[SuccessMessage] = "You have successfully removed the item from the cart!";

                return RedirectToAction("Cart", "Cart");

            }
            catch(Exception)
            {
                return GeneralErrorMessage();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Increase(int id)
        {
            try
            {
                var userId = User.GetId();

                var cart = await cartService.GetCurrCartByUserIdAsync(userId!);

                await cartService.IncreaseItemCountAsync(id, cart!.Id);
            }
            catch
            {
                TempData[ErrorMessage] = "An unexpected error occurred with cart! Please, try again.";

                return RedirectToAction("Cart", "Cart");
            }

            return RedirectToAction("Cart", "Cart");

        }

        [HttpPost]
        public async Task<IActionResult> Decrease(int id)
        {
            try
            {
                var userId = User.GetId();

                var cart = await cartService.GetCurrCartByUserIdAsync(userId!);

                await cartService.DecreaseItemCountAsync(id, cart!.Id);
            }
            catch
            {
                TempData[ErrorMessage] = "An unexpected error occurred with cart! Please, try again.";

                return RedirectToAction("Cart", "Cart");
            }

            return RedirectToAction("Cart", "Cart");
        }

        private IActionResult GeneralErrorMessage()
        {
            TempData[ErrorMessage] = "An unexpected error occurred with cart! Please, try again.";

            var previousUrl = Request.Headers["Referer"].ToString();

            return Redirect(previousUrl);
        }
    }
}
