namespace PetShop.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using PetShop.Services.Data;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Order;

    using static DatabaseSeeder;

    public class OrderServiceTests
    {
        private DbContextOptions<PetShopDbContext> dbOptions;
        private PetShopDbContext dbContext;

        private IOrderService orderService;

        [SetUp]
        public void SetUp()
        {
            dbOptions = new DbContextOptionsBuilder<PetShopDbContext>()
                .UseInMemoryDatabase("PetShopInMemory" + Guid.NewGuid().ToString())
                .Options;

            dbContext = new PetShopDbContext(dbOptions);

            dbContext.Database.EnsureCreated();
            SeedDatabase(dbContext);

            orderService = new OrderService(dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetOrderDetailsAsync_ShouldReturnOrderModel()
        {
            var order = await dbContext
                .Orders
                .FirstAsync();

            var resultOrder = await orderService.GetOrderDetailsAsync(order!.CartId.ToString());

            Assert.Multiple(() =>
            {
                Assert.That(resultOrder, Is.Not.Null);

                Assert.That(order.Id.ToString(), Is.EqualTo(resultOrder!.Id));
                Assert.That(order.FirstName, Is.EqualTo(resultOrder.FirstName));
                Assert.That(order.LastName, Is.EqualTo(resultOrder.LastName));
                Assert.That(order.Country, Is.EqualTo(resultOrder.Country));
                Assert.That(order.City, Is.EqualTo(resultOrder.City));
                Assert.That(order.Address, Is.EqualTo(resultOrder.Address));
                Assert.That(order.PostCode, Is.EqualTo(resultOrder.PostCode));
                Assert.That(order.CartId.ToString(), Is.EqualTo(resultOrder.CartId));
                Assert.That(order.UserId.ToString(), Is.EqualTo(resultOrder.UserId));
                Assert.That(order.TotalPrice, Is.EqualTo(resultOrder.TotalPrice));
            });
        }

        [Test]
        public async Task GetAllOrdersByUserIdAsync_ShouldResturnListOfOrders()
        {
            var userId = User!.Id.ToString();

            var allOrders = await dbContext
                .Orders
                .Where(o => o.UserId.ToString() == userId)
                .ToListAsync();

            var result = await orderService.GetAllOrdersByUserIdAsync(userId);

            Assert.That(allOrders, Has.Count.EqualTo(result.Count()));

        }

        [Test]
        public async Task CreateOrderAsync_ShouldCreateNewOrder()
        {
            var before = await dbContext
                .Orders
                .Where(o => o.UserId == User!.Id)
                .ToListAsync();

            var order = new OrderFormViewModel()
            {
                FirstName = "Test",
                LastName = "Last Name Test",
                Country = "Tes Country",
                City = "Test City",
                Address = "Test Address",
                PostCode = "11 POSTCODE",
                CartId = Guid.NewGuid().ToString(),
                UserId = User!.Id.ToString(),
                TotalPrice = 22.35M
            };

            await orderService.CreateOrderAsync(order);

            var result = await dbContext
                .Orders
                .Where(o=>o.UserId == User.Id)
                .ToListAsync();

            Assert.That(result, Has.Count.EqualTo(before.Count()+1));
        }

        [Test]
        public async Task GetLastOrderListByUserIdAsync_ShouldReturnLastOrder()
        {
            var userId = User!.Id;

            var expected = await dbContext
                .Orders
                .Where(o=>o.UserId == userId)
                .LastAsync();

            var result = await orderService.GetLastOrderListByUserIdAsync(userId.ToString());

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);

                Assert.That(expected.Id.ToString(), Is.EqualTo(result!.Id));
                Assert.That(expected.FirstName, Is.EqualTo(result.FirstName));
                Assert.That(expected.LastName, Is.EqualTo(result.LastName));
                Assert.That(expected.Country, Is.EqualTo(result.Country));
                Assert.That(expected.City, Is.EqualTo(result.City));
                Assert.That(expected.Address, Is.EqualTo(result.Address));
                Assert.That(expected.PostCode, Is.EqualTo(result.PostCode));
                Assert.That(expected.CartId.ToString(), Is.EqualTo(result.CartId));
                Assert.That(expected.UserId.ToString(), Is.EqualTo(result.UserId));
                Assert.That(expected.TotalPrice, Is.EqualTo(result.TotalPrice));
            });
        }
    }
}
