namespace PetShop.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Services.Data;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Category;

    using static DatabaseSeeder;

    public class CategoryServiceTests
    {
        private DbContextOptions<PetShopDbContext> dbOptions;
        private PetShopDbContext dbContext;

        private ICategoryService categoryService;

        int categoryId;

        [SetUp]
        public void SetUp()
        {
            dbOptions = new DbContextOptionsBuilder<PetShopDbContext>()
                .UseInMemoryDatabase("PetShopInMemory" + Guid.NewGuid().ToString())
                .Options;

            dbContext = new PetShopDbContext(dbOptions);

            dbContext.Database.EnsureCreated();
            SeedDatabase(dbContext);

            categoryService = new CategoryService(dbContext);

            categoryId = 2;
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task AllCateagoriesAsync_ShouldReturnListOfAllCategories()
        {
            var expected = await dbContext
                .Categories
                .ToListAsync();

            var result = await categoryService.AllCateagoriesAsync();

            Assert.That(expected, Has.Count.EqualTo(result.Count()));
        }

        [Test]
        public async Task IsCategoryExistAsync_ShouldReturnTrue()
        {
            bool result = await categoryService.IsCategoryExistAsync(categoryId);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task IsCategoryExistAsync_ShouldReturnFalse()
        {
            int notExistingCateogryId = 2332246;

            bool result = await categoryService.IsCategoryExistAsync(notExistingCateogryId);

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task AllCategoriesNameAsync_ShouldReturnArrayOfAllCategoryNames()
        {
            var expected = await dbContext
                .Categories
                .Where(c => c.IsDeleted == false)
                .Select(c => c.Name)
                .ToArrayAsync();

            var result = await categoryService.AllCategoriesNameAsync();

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public async Task IsCategoryExistByNameAsync_ShouldReturnTrue()
        {
            var categoryName = await dbContext
                .Categories
                .Where(c => c.Id == categoryId)
                .Select(c => c.Name)
                .FirstAsync();

            bool result = await categoryService.IsCategoryExistByNameAsync(categoryName);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task IsCategoryExistByNameAsync_ShouldReturnFalse()
        {
            var categoryName = "Unexisting Test Name";

            bool result = await categoryService.IsCategoryExistByNameAsync(categoryName);

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task CreateNewCategoryAsync_ShouldIncreaseCountOfCollection()
        {
            int currCount = await dbContext
                .Categories.CountAsync();

            var model = new NewCategoryViewModel()
            {
                Name = "Test Category Name",
                Image = "TestImage.png"
            };

            await categoryService.CreateNewCategoryAsync(model);

            int resultCount = await dbContext
                .Categories.CountAsync();

            Assert.That(resultCount, Is.EqualTo(currCount+1));
        }

        [Test]
        public async Task GetCategoryByIdAsync_ShouldReturnRightCateogry()
        {
            var expect = await dbContext
                .Categories
                .Where(c => c.Id == categoryId && !c.IsDeleted)
                .FirstAsync();

            var result = await categoryService.GetCategoryByIdAsync(categoryId);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);

                Assert.That(expect.Name, Is.EqualTo(result.Name));
                Assert.That(expect.Image, Is.EqualTo(result.Image));
            });
        }

        [Test]
        public async Task EditCategoryAsync_ShouldReturnEditedCategory()
        {
            var model = new NewCategoryViewModel()
            {
                Name = "Edited Name",
                Image = "Edited Image",
            };

            await categoryService.EditCategoryAsync(categoryId, model);

            var result = await dbContext
                .Categories
                .Where(c => c.Id == categoryId && !c.IsDeleted)
                .FirstAsync();

            Assert.Multiple(() =>
            {
                Assert.That(result.Name, Is.EqualTo(model.Name));
                Assert.That(result.Image, Is.EqualTo(model.Image));
            });


        }

        [Test]
        public async Task SoftDeleteCategoryAsync_ShouldTurnIsDeleteToTrue()
        {
            var category = await dbContext
                .Categories
                .Where(c=>c.Id == categoryId)
                .FirstAsync();

            category.IsDeleted = false;

            await categoryService.SoftDeleteCategoryAsync(categoryId);

            Assert.That(category.IsDeleted, Is.True);
        }
    }
}
