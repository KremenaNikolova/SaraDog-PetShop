namespace PetShop.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using PetShop.Services.Data;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.User;

    using static DatabaseSeeder;

    public class UserServiceTests
    {
        private DbContextOptions<PetShopDbContext> dbOptions;
        private PetShopDbContext dbContext;

        private IUserService userService;


        [SetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<PetShopDbContext>()
                .UseInMemoryDatabase("PetShopInMemory" + Guid.NewGuid().ToString())
                .Options;

            dbContext = new PetShopDbContext(dbOptions);

            dbContext.Database.EnsureCreated();
            SeedDatabase(dbContext);

            userService = new UserService(dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }


        [Test]
        public async Task GetAllUsersAsync_ShouldReturnListOfAllUsers()
        {
            var allUsers = await dbContext.Users.ToListAsync();

            var resultUser = await userService.GetAllUsersAsync();
            var usersCount = resultUser.Count();

            Assert.That(usersCount, Is.EqualTo(allUsers.Count()));
        }

        [Test]
        public async Task GetUserByIdAsync_ShouldReturnNotNull()
        {
            var userId = User!.Id;

            var user = await userService.GetUserByIdAsync(userId.ToString());
            Assert.Multiple(() =>
            {
                Assert.That(user, Is.Not.Null);

                Assert.That(User.UserName, Is.EqualTo(user.UserName));
                Assert.That(User.Email, Is.EqualTo(user.Email));
                Assert.That(User.FirstName, Is.EqualTo(user.FirstName));
                Assert.That(User.LastName, Is.EqualTo(user.LastName));
                Assert.That(User.Image, Is.EqualTo(user.Image));
            });
        }

        [Test]
        public async Task GetAllUsersExceptCurrOneAsync_ShouldReturnAllUsersMinusOne()
        {
            var currUser = User;

            var allUsers = dbContext.Users.Count();
            var users = await userService.GetAllUsersExceptCurrOneAsync(currUser!.Id.ToString());

            Assert.That(users.Count(), Is.EqualTo(allUsers - 1));
        }

        [Test]
        public async Task EditProfileAsync_ShouldReturnEditedUser()
        {
            var user = await dbContext.Users.FirstOrDefaultAsync();

            var model = new EditUserProfileViewModel()
            {
                FirstName = "Petar",
                LastName = "Petrov",
                Country = "Bulgaria",
                City = "City",
                Address = "TestAddress",
                PostCode = "9932TEST",
                Image = "NoImage.png",
                Email = "test@abv.bg",
                UserName = "testOv"
            };

            await userService.EditProfileAsync(user!.Id.ToString(), model);

            Assert.Multiple(() =>
            {
                Assert.That(user, Is.Not.Null);

                Assert.That(user.UserName, Is.EqualTo(model.UserName));
                Assert.That(user.Email, Is.EqualTo(model.Email));
                Assert.That(user.FirstName, Is.EqualTo(model.FirstName));
                Assert.That(user.LastName, Is.EqualTo(model.LastName));
                Assert.That(user.Image, Is.EqualTo(model.Image));
                Assert.That(user.Country, Is.EqualTo(model.Country));
                Assert.That(user.City, Is.EqualTo(model.City));
                Assert.That(user.Address, Is.EqualTo(model.Address));
                Assert.That(user.PostCode, Is.EqualTo(model.PostCode));
            });
        }

        [Test]
        public async Task SoftDeleteUserAsync_ShouldIsDeleteGoTrue()
        {
            string userId = User!.Id.ToString();

            await userService.SoftDeleteUserAsync(userId);

            Assert.Multiple(() =>
            {
                Assert.That(User.IsDeleted, Is.True);

                Assert.That(User.Image, Is.Null);
                Assert.That(User.FirstName, Is.Null);
                Assert.That(User.LastName, Is.Null);
                Assert.That(User.Country, Is.Null);
                Assert.That(User.City, Is.Null);
                Assert.That(User.Address, Is.Null);
                Assert.That(User.PostCode, Is.Null);
            });
        }

        [Test]
        public async Task ReverseIsModeratorAsync_ShouldReturnOposite()
        {
            string userId = User!.Id.ToString();

            bool isModeratorBefore = User.IsModerator;

            await userService.ReverseIsModeratorAsync(userId);

            Assert.That(User.IsModerator, Is.Not.EqualTo(isModeratorBefore));
        }

    }
}