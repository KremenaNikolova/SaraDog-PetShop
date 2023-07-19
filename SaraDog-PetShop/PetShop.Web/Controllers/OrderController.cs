namespace PetShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Infrastructure.Extensions;
    using PetShop.Web.ViewModels.Order;

    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly ICartService cartService;

        public OrderController(IOrderService orderService, ICartService cartService)
        {
            this.orderService = orderService;
            this.cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            try
            {
                var userId = User.GetId();

                var currCart = await cartService.GetCartByUserIdAsync(userId!);

                var order = await orderService.GetOrderDetailsAsync(currCart!.Id);

                if (order == null)
                {
                    order = new OrderFormViewModel()
                    {
                        UserId = userId!,
                        CartId = currCart.Id,
                        TotalPrice = currCart.TotalPrice
                    };

                }
                return View(order);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
