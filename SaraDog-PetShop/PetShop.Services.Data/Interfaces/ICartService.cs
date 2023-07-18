namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Web.ViewModels.Cart;

    public interface ICartService
    {
        Task<CartFormViewModel?> GetCartByUserIdAsync(string userId);
    }
}
