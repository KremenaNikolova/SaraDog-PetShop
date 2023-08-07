namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Web.ViewModels.Cart;

    public interface ICartService
    {
        Task<CartFormViewModel?> GetCurrCartByUserIdAsync(string userId);

        Task<CartFormViewModel> GetCartByOrderIdAsync(string orderId);

        Task CreateCartAsync(string userId);

        Task AddItemToCartAsync(int itemId, string cartId, string userId);

        Task RemoveItemFromCartAsync(int cartItemId, string cartId);

        Task IncreaseItemCountAsync(int itemId, string cartId);

        Task DecreaseItemCountAsync(int itemId, string cartId);
    }
}
