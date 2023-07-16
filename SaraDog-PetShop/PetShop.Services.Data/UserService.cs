namespace PetShop.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.ApplicationUser;
    using PetShop.Web.ViewModels.Category;
    using PetShop.Web.ViewModels.Item;

    public class UserService : IUserService
    {
        private readonly PetShopDbContext dbContext;

        public UserService(PetShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ApplicationUserViewModel>> GetAllUsersAsync()
        {
            var allUsers = await dbContext
                .Users
                .Select(u => new ApplicationUserViewModel()
                {
                    Id = u.Id.ToString(),
                    UserName = u.UserName,
                    Email = u.Email,
                    IsManager = u.IsManager
                })
                .ToArrayAsync();

            return allUsers;

        }
    }
}
