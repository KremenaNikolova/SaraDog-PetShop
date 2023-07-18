namespace PetShop.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Cart;

    public class CartService : ICartService
    {
        private readonly PetShopDbContext dbContext;

        public CartService(PetShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<CartFormViewModel?> GetCartByUserIdAsync(string userId)
        {
            var cart = await dbContext
                .Carts
                .Where(c=>c.UserId.ToString() == userId)
                .Select(c=> new CartFormViewModel()
                {
                    Items = c.CartItems
                    .Select(ci=> new CartItemViewModel()
                    {
                        Id = ci.ItemId,
                        Title = ci.Item.Title,
                        Price = ci.Item.Price,
                        Quantity = ci.Quantity,
                        TotalPrice = ci.Quantity * ci.Item.Price
                    })
                    .ToArray(),
                    TotalPrice =  c.TotalPrice,

                })
                .FirstOrDefaultAsync();

            return cart;
        }
    }
}
