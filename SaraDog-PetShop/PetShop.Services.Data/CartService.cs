namespace PetShop.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PetShop.Data.Models;
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

        public async Task<CartFormViewModel?> GetCurrCartByUserIdAsync(string userId)
        {
            var cart = await dbContext
                .Carts
                .OrderByDescending(c => c.CreatedOn)
                .Where(c => c.UserId.ToString() == userId)
                .Select(c => new CartFormViewModel()
                {
                    Id = c.Id.ToString(),
                    Items = c.CartItems
                    .Select(ci => new CartItemViewModel()
                    {
                        ItemId = ci.ItemId,
                        Title = ci.Item.Title,
                        Image = ci.Item.TitleImage,
                        Price = ci.Item.Price,
                        Quantity = ci.Quantity,
                        TotalPrice = ci.Quantity * ci.Item.Price
                    })
                    .ToArray()

                })
                .FirstOrDefaultAsync();

            if(cart != null)
            {
                cart!.TotalPrice += cart.Items.Select(i => i.TotalPrice).Sum();
                
            }

            return cart;
        }

        public async Task<CartFormViewModel> GetCartByOrderIdAsync(string orderId)
        {
            var currCart = await dbContext
                .Orders
                .Where(o => o.Id.ToString() == orderId)
                .Select(o => new CartFormViewModel()
                {
                    Id = o.CartId.ToString(),
                    Items = o.Cart.CartItems
                    .Select(ci => new CartItemViewModel()
                    {
                        ItemId = ci.ItemId,
                        Title = ci.Item.Title,
                        Image = ci.Item.TitleImage,
                        Price = ci.Item.Price,
                        Quantity = ci.Quantity,
                        TotalPrice = ci.Quantity * ci.Item.Price
                    })
                    .ToArray()
                })
                .FirstAsync();

            return currCart;

        }

        public async Task CreateCartAsync(string userId)
        {
            Guid guidId;

            bool isValidId = Guid.TryParse(userId, out guidId);

            if (isValidId)
            {
                Cart cart = new Cart()
                {
                    UserId = guidId
                };

                dbContext.Carts.Add(cart);
                await dbContext.SaveChangesAsync();
            }

        }

        public async Task AddItemToCartAsync(int itemId, string cartId, string userId)
        {
            bool isItemExistInCart = await dbContext
                .CartItems
                .AnyAsync(ci => ci.ItemId == itemId 
                             && ci.CartId.ToString() == cartId);

            Item currItem = await dbContext
                .Items
                .Where(i => i.Id == itemId)
                .FirstAsync();

            Cart cart = await dbContext
                .Carts
                .Where(c => c.Id.ToString() == cartId)
                .FirstAsync();

            CartItem? currCartItem;

            if (!isItemExistInCart)
            {
                currCartItem = await dbContext
                 .CartItems
                 .Where(ci => ci.ItemId == itemId && ci.CartId.ToString() == cartId)
                 .FirstOrDefaultAsync();

                if (currCartItem == null)
                {
                    currCartItem = new CartItem()
                    {
                        ItemId = currItem.Id,
                        CartId = cart.Id
                    };
                }

                dbContext.CartItems.Add(currCartItem);

            }
            else
            {
                currCartItem = await dbContext
                    .CartItems
                    .Where(ci => ci.ItemId == itemId && ci.CartId.ToString() == cartId)
                    .FirstAsync();

                currCartItem.Quantity++;
            }

            await dbContext.SaveChangesAsync();

        }

        public async Task RemoveItemFromCartAsync(int itemId, string cartId)
        {
            var cartItem = await dbContext
                .CartItems
                .Where(ci => ci.ItemId == itemId && ci.CartId.ToString() == cartId)
                .FirstAsync();

            if (cartItem != null)
            {
                dbContext.CartItems.Remove(cartItem);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task IncreaseItemCountAsync(int itemId, string cartId)
        {
            var cartItem = await dbContext
                .CartItems
                .Where(ci => ci.ItemId == itemId && ci.CartId.ToString() == cartId)
                .FirstAsync();

            cartItem.Quantity++;

            await dbContext.SaveChangesAsync();
        }

        public async Task DecreaseItemCountAsync(int itemId, string cartId)
        {
            var cartItem = await dbContext
                .CartItems
                .Where(ci => ci.ItemId == itemId && ci.CartId.ToString() == cartId)
                .FirstAsync();

            cartItem.Quantity--;

            await dbContext.SaveChangesAsync();
        }


    }
}
