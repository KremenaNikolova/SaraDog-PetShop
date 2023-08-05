namespace PetShop.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Services.Data;
    using PetShop.Web.Data;

    using static DatabaseSeeder;

    public class CartServiceTests
    {
        private DbContextOptions<PetShopDbContext> dbOptions;
        private PetShopDbContext dbContext;

        private ICartService cartService;

        int itemId;
        string userId;
        string orderId;
        string cartId;

        [SetUp]
        public void SetUp()
        {
            dbOptions = new DbContextOptionsBuilder<PetShopDbContext>()
                .UseInMemoryDatabase("PetShopInMemory" + Guid.NewGuid().ToString())
                .Options;

            dbContext = new PetShopDbContext(dbOptions);

            dbContext.Database.EnsureCreated();
            SeedDatabase(dbContext);

            cartService = new CartService(dbContext);

            itemId = 2;
            userId = User!.Id.ToString();
            orderId = Order!.Id.ToString();
            cartId = Cart!.Id.ToString();
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetCurrCartByUserIdAsync_ShouldReturnLastCreatedCartOfThisUser()
        {
            var expected = await dbContext
                .Carts
                .Where(c => c.UserId.ToString() == userId)
                .LastAsync();

            var result = await cartService.GetCurrCartByUserIdAsync(userId);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);

                Assert.That(expected.Id.ToString(), Is.EqualTo(result.Id));
                Assert.That(expected.CartItems.Count(), Is.EqualTo(result.Items.Count()));
            });

        }

        [Test]
        public async Task GetCartByOrderIdAsync_ShouldReturnRightCart()
        {
            var expected = await dbContext
                .Orders
                .Where(o => o.Id.ToString() == orderId)
                .Select(o => o.Cart)
                .FirstAsync();

            var result = await cartService.GetCartByOrderIdAsync(orderId);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);

                Assert.That(expected.Id.ToString(), Is.EqualTo(result.Id));
                Assert.That(expected.CartItems.Count(), Is.EqualTo(result.Items.Count()));
            });
        }

        [Test]
        public async Task CreateCartAsync_ShouldCreateNewCard()
        {
            var before = dbContext
                .Carts
                .Where(c=>c.UserId.ToString()==userId)
                .Count();

            await cartService.CreateCartAsync(userId);

            var result = dbContext
                .Carts
                .Where(c => c.UserId.ToString() == userId)
                .Count();

            Assert.That(result, Is.EqualTo(before + 1));
        }

        [Test]
        public async Task AddItemToCartAsync_ShouldAddItemToLastCurrUserCart()
        {
            var before = dbContext
                .CartItems
                .Where(ci => ci.ItemId == itemId && ci.CartId.ToString() == cartId)
                .Count();

            await cartService.AddItemToCartAsync(itemId, cartId, userId);

            var result = dbContext
                .CartItems
                .Where(ci => ci.ItemId == itemId && ci.CartId.ToString() == cartId)
                .Count();

            Assert.That(result, Is.EqualTo(before + 1));

        }

        [Test]
        public async Task AddItemToCartAsync_ShouldIncreaseQuantity()
        {
            await cartService.AddItemToCartAsync(itemId, cartId, userId);

            int before = dbContext
                .CartItems
                .Where(ci => ci.ItemId == itemId && ci.CartId.ToString() == cartId)
                .Select(ci=>ci.Quantity)
                .First();

            await cartService.AddItemToCartAsync(itemId, cartId, userId);

            int result = dbContext
               .CartItems
               .Where(ci => ci.ItemId == itemId && ci.CartId.ToString() == cartId)
               .Select(ci => ci.Quantity)
               .First();

            Assert.That(result, Is.EqualTo(before + 1));
        }

        [Test]
        public async Task RemoveItemFromCartAsync_ShouldRemoveItemFromCollection()
        {
            int alreadyAddedCartItemId = 11;

            int before = dbContext
               .CartItems
               .Where(ci => ci.CartId.ToString() == cartId)
               .Count();

            await cartService.RemoveItemFromCartAsync(alreadyAddedCartItemId, cartId);

            int result = dbContext
               .CartItems
               .Where(ci => ci.CartId.ToString() == cartId)
               .Count();

            Assert.That(result, Is.EqualTo(before - 1));
        }

        [Test]
        public async Task IncreaseItemCountAsync_ShouldIncreaseQuantityOfItem()
        {
            int alreadyAddedCartItemId = 11;

            int before = dbContext
                .CartItems
                .Where(ci => ci.ItemId == alreadyAddedCartItemId && ci.CartId.ToString() == cartId)
                .Select(ci => ci.Quantity)
                .First();

            await cartService.IncreaseItemCountAsync(alreadyAddedCartItemId, cartId);

            int result = dbContext
                .CartItems
                .Where(ci => ci.ItemId == alreadyAddedCartItemId && ci.CartId.ToString() == cartId)
                .Select(ci => ci.Quantity)
                .First();

            Assert.That(result, Is.EqualTo(before + 1));
        }

        [Test]
        public async Task DecreaseItemCountAsync_ShouldDecreaseQuantityOfItem()
        {
            int alreadyAddedCartItemId = 11;

            int before = dbContext
                .CartItems
                .Where(ci => ci.ItemId == alreadyAddedCartItemId && ci.CartId.ToString() == cartId)
                .Select(ci => ci.Quantity)
                .First();

            await cartService.DecreaseItemCountAsync(alreadyAddedCartItemId, cartId);

            int result = dbContext
                .CartItems
                .Where(ci => ci.ItemId == alreadyAddedCartItemId && ci.CartId.ToString() == cartId)
                .Select(ci => ci.Quantity)
                .First();

            Assert.That(result, Is.EqualTo(before - 1));
        }
    }
}
