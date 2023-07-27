namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Web.ViewModels.Cart;

    public interface ICartService
    {
        Task<CartFormViewModel?> GetCurrCartByUserIdAsync(string userId);

        Task CreateCartAsync(string userId);

        Task AddItemToCartAsync(int itemId, string cartId, string userId);

        Task RemoveItemFromCartAsync(int cartItemId);

        Task IncreaseItemCountAsync(int itemId);

        Task DecreaseItemCountAsync(int itemId);
    }
}
