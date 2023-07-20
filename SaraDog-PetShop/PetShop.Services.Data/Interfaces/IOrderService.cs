namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Web.ViewModels.Order;

    public interface IOrderService
    {
        Task<OrderFormViewModel?> GetOrderDetailsAsync(string cartId);

        Task CreateOrderAsync(OrderFormViewModel orderModel);

        Task<OrderFormViewModel?> GetOrderListByUserIdAsync(string userId);
        
    }
}
