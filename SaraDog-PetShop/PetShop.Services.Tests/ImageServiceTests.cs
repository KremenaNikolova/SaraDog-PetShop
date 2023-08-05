namespace PetShop.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    using PetShop.Services.Data.Interfaces;
    using PetShop.Services.Data;
    using PetShop.Web.Data;
    
    using static DatabaseSeeder;

    public class ImageServiceTests
    {
        private DbContextOptions<PetShopDbContext> dbOptions;
        private PetShopDbContext dbContext;

        private IImageService imageService;
        private IConfiguration? configuration;

        [SetUp]
        public void SetUp()
        {
            dbOptions = new DbContextOptionsBuilder<PetShopDbContext>()
                .UseInMemoryDatabase("PetShopInMemory" + Guid.NewGuid().ToString())
                .Options;

            dbContext = new PetShopDbContext(dbOptions);

            dbContext.Database.EnsureCreated();
            SeedDatabase(dbContext);

            imageService = new ImageService(dbContext, configuration!);

        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test] 
        public void GetLandingPageImage_ShouldReturnLandingImage()
        {
            var expected = "CroppedWorkout.jpg";

            var result = imageService.GetLandingPageImage();

            Assert.That(expected, Is.EqualTo(result.LandingImage));
        }
    }
}
