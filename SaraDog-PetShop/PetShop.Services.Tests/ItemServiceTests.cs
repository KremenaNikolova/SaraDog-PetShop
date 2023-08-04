namespace PetShop.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Services.Data;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Item;

    using static DatabaseSeeder;

    public class ItemServiceTests
    {
        private DbContextOptions<PetShopDbContext> dbOptions;
        private PetShopDbContext dbContext;

        private IItemService itemService;

        int itemId;
        int categoryId;
        string userId;

        [SetUp]
        public void SetUp()
        {
            dbOptions = new DbContextOptionsBuilder<PetShopDbContext>()
                .UseInMemoryDatabase("PetShopInMemory" + Guid.NewGuid().ToString())
                .Options;

            dbContext = new PetShopDbContext(dbOptions);

            dbContext.Database.EnsureCreated();
            SeedDatabase(dbContext);

            itemService = new ItemService(dbContext);

            itemId = 2;
            categoryId = 2;
            userId = User!.Id.ToString();
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetAllIActivetemsAsync_ShouldReturnListOfAllEnabledItems()
        {
            var items = await dbContext
                .Items
                .Where(i => i.IsActive)
                .ToListAsync();

            var result = await itemService.GetAllIActivetemsAsync();

            Assert.That(items, Has.Count.EqualTo(result.Count()));
        }

        [Test]
        public async Task CreateItemAsync_ShouldAddItemToCollection()
        {
            var before = await dbContext
                .Items
                .ToListAsync();

            var model = new ItemFormViewModel()
            {
                Title = "Test Title",
                Description = "Test Description",
                UploadPicture = "TestImage.png",
                Price = 2.33M,
                CategoryId = 2
            };

            await itemService.CreateItemAsync(model);

            var result = await dbContext
                .Items
                .ToListAsync();

            Assert.That(result, Has.Count.EqualTo(before.Count() + 1));
        }

        [Test]
        public async Task GetItemByIdAsync_ShouldReturnCorrectItem()
        {
            var expected = await dbContext
                .Items
                .Where(i => i.Id == itemId)
                .FirstAsync();

            var result = await itemService.GetItemByIdAsync(itemId);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);

                Assert.That(expected.Title, Is.EqualTo(result.Title));
                Assert.That(expected.Description, Is.EqualTo(result.Description));
                Assert.That(expected.Price, Is.EqualTo(result.Price));
                Assert.That(expected.TitleImage, Is.EqualTo(result.UploadPicture));
                Assert.That(expected.CategoryId, Is.EqualTo(result.CategoryId));
                Assert.That(expected.IsActive, Is.EqualTo(result.IsActive));
            });

        }

        [Test]
        public async Task EditProductAsync_ShouldReturnModifiedItem()
        {
            var model = new ItemFormViewModel()
            {
                Title = "Edited Test",
                Description = "Edited Description",
                Price = 202.45M,
                UploadPicture = "EditedImage.jpg",
                CategoryId = categoryId,
                IsActive = true
            };

            await itemService.EditProductAsync(itemId, model);

            var result = await dbContext
                .Items
                .Where(i => i.Id == itemId)
                .FirstAsync();

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);

                Assert.That(result.Title, Is.EqualTo(model.Title));
                Assert.That(result.Description, Is.EqualTo(model.Description));
                Assert.That(result.Price, Is.EqualTo(model.Price));
                Assert.That(result.TitleImage, Is.EqualTo(model.UploadPicture));
                Assert.That(result.CategoryId, Is.EqualTo(model.CategoryId));
                Assert.That(result.IsActive, Is.EqualTo(model.IsActive));
            });

        }

        [Test]
        public async Task GetAllItemsInFavoritesAsync_ShouldReturnAllThisUserItems()
        {
            var expected = await dbContext
                .UserItems
                .Where(ut=>ut.UserId.ToString() == userId)
                .ToListAsync();

            var result = await itemService.GetAllItemsInFavoritesAsync(userId);

            Assert.That(expected, Has.Count.EqualTo(result.Count()));
        }

        [Test]
        public async Task AddToFavouritesAsync_ShouldAddItemToCollection()
        {
            var before = await dbContext
                .UserItems
                .Where(ut => ut.UserId.ToString() == userId)
                .ToListAsync();

            await itemService.AddToFavouritesAsync(userId, itemId);

            var result = await dbContext
                .UserItems
                .Where(ut => ut.UserId.ToString() == userId)
                .ToListAsync();

            Assert.That(result, Has.Count.EqualTo(before.Count()+1));
        }

        [Test]
        public async Task IsAlreadyAddedAsync_ShouldReturnTrue()
        {
            await itemService.AddToFavouritesAsync(userId, itemId);

            bool isAdded = itemService.IsAlreadyAddedAsync(userId, itemId);

            Assert.That(isAdded, Is.True);
        }

        [Test]
        public void IsAlreadyAddedAsync_ShouldReturnFalse()
        {
            bool isAdded = itemService.IsAlreadyAddedAsync(userId, itemId);

            Assert.That(isAdded, Is.False);
        }

        [Test]
        public async Task GetDetailsByIdAsync_ShouldReturnRightItem()
        {
            var expected = await dbContext
                .Items
                .Where(i=>i.Id == itemId)
                .FirstAsync();

            var result = await itemService.GetDetailsByIdAsync(itemId);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);

                Assert.That(expected.Id, Is.EqualTo(result.Id));
                Assert.That(expected.Title, Is.EqualTo(result.Title));
                Assert.That(expected.Description, Is.EqualTo(result.Description));
                Assert.That(expected.Price, Is.EqualTo(result.Price));
                Assert.That(expected.Category.Name, Is.EqualTo(result.Category));
                Assert.That(expected.TitleImage, Is.EqualTo(result.Image));
            });
        }

        [Test]
        public async Task SoftDeleteItemAsync_ShouldTurnIsDeleteToTrue()
        {
            var item = await dbContext
                .Items
                .Where(i=>i.Id == itemId)
                .FirstAsync();

            Assert.That(item.IsDeleted, Is.False);

            await itemService.SoftDeleteItemAsync(itemId);

            Assert.That(item.IsDeleted, Is.True);
        }

        [Test]
        public async Task TurnActivityAsync_ShouldReturnOposite()
        {
            var item = await dbContext
                .Items
                .Where(i=>i.Id == itemId)
                .FirstAsync();

            item.IsActive = false;

            await itemService.TurnActivityAsync(itemId);

            Assert.That(item.IsActive, Is.True);
        }

        [Test]
        public async Task AllItemsByChoosenCategoryAsync_ShouldReturnArrayOfItems()
        {
            var expected = await dbContext
                .Items
                .Where(i => i.CategoryId == categoryId)
                .ToListAsync();

            var result = await itemService.AllItemsByChoosenCategoryAsync(categoryId);

            Assert.That(expected, Has.Count.EqualTo(result.Count()));
        }
    }
}
