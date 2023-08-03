namespace PetShop.Services.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    
    using PetShop.Data.Models;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Services.Data.Models.User;
    using PetShop.Web.Data;

    using PetShop.Web.ViewModels.User;
    using PetShop.Web.ViewModels.User.Enums;

    public class UserService : IUserService
    {
        private readonly PetShopDbContext dbContext;

        public UserService(PetShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsersAsync()
        {
            var allUsers = await dbContext
                .Users
                .Select(u => new UserViewModel()
                {
                    Id = u.Id.ToString(),
                    UserName = u.UserName,
                    Email = u.Email,
                    IsModerator = u.IsModerator,
                    CreatedOn = u.CreatedOn,
                })
                .ToArrayAsync();

            return allUsers;

        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsersExceptCurrOneAsync(string userId)
        {
            var allUsers = await dbContext
                .Users
                .Where(u=>u.Id.ToString() != userId)
                .Select(u => new UserViewModel()
                {
                    Id = u.Id.ToString(),
                    UserName = u.UserName,
                    Email = u.Email,
                    IsModerator = u.IsModerator,
                    CreatedOn = u.CreatedOn,
                })
                .ToArrayAsync();

            return allUsers;
        }

        public async Task<AllUsersFilteredAndPagedServiceModel> AllUsersQueryAsync(AllUsersQueryModel queryModel)
        {
            IQueryable<ApplicationUser> userQuery = dbContext
                .Users
                .Where(u => u.IsDeleted == false)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";

                userQuery = userQuery
                    .Where(c => EF.Functions.Like(c.UserName, wildCard) ||
                                EF.Functions.Like(c.Email, wildCard) ||
                                EF.Functions.Like(c.Address!, wildCard) ||
                                EF.Functions.Like(c.PhoneNumber, wildCard));
            }

            userQuery = queryModel.ItemSorting switch
            {
                UsersSorting.NameAscending => userQuery
                    .OrderBy(u => u.UserName),
                UsersSorting.NameDescending => userQuery
                    .OrderByDescending(u => u.UserName),
                UsersSorting.CreatedAscending => userQuery
                .OrderBy(u => u.CreatedOn),
                UsersSorting.CreatedDescending => userQuery
                .OrderByDescending(u => u.CreatedOn),
                _ => userQuery
                    .OrderBy(u => u.CreatedOn)
            };

            IEnumerable<UserViewModel> searchedUsers = await userQuery
                .Where(u => u.IsDeleted == false)
                .Skip((queryModel.CurrentPage - 1) * queryModel.UsersPerPage)
                .Take(queryModel.UsersPerPage)
                .Select(u => new UserViewModel()
                {
                    Id = u.Id.ToString(),
                    UserName = u.UserName,
                    Email = u.Email,
                    IsModerator = u.IsModerator,
                    CreatedOn = u.CreatedOn
                })
                .ToArrayAsync();

            int totalUsers = userQuery.Count();

            return new AllUsersFilteredAndPagedServiceModel()
            {
                TotalUsersCount = totalUsers,
                Users = searchedUsers
            };
        }

        public async Task<EditUserProfileViewModel> GetUserByIdAsync(string userId)
        {
            var userModel = await dbContext
                .Users
                .Where(u=>u.Id.ToString()==userId
                       && u.IsDeleted == false)
                .Select(u=> new EditUserProfileViewModel()
                {
                    Id=u.Id.ToString(),
                    UserName = u.UserName,
                    Image = u.Image,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Country = u.Country,
                    City = u.City,
                    Address = u.Address,
                    PostCode = u.PostCode,
                })
                .FirstAsync();

            if(string.IsNullOrWhiteSpace(userModel.Image))
            {
                userModel.Image = "catAvatar.jpg";
            }

            return userModel;
        }

        public async Task EditProfileAsync(string userId, EditUserProfileViewModel model)
        {
            var user = await dbContext
                .Users
                .Where(u => u.Id.ToString() == userId
                         && u.IsDeleted == false)
                .FirstAsync();

            if(user !=null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Country = model.Country;
                user.City = model.City;
                user.Address = model.Address;
                user.PostCode = model.PostCode;
                user.Image = model.Image;
                user.Email = model.Email;
                user.UserName = model.UserName;

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task SoftDeleteUserAsync(string userId)
        {
            var user = await dbContext
                .Users
                .Where(u=>u.Id.ToString()==userId
                        && u.IsDeleted == false)
                .FirstAsync();

            user.FirstName=null;
            user.LastName=null;
            user.Country=null;
            user.City=null;
            user.Address=null;
            user.PostCode=null;
            user.Image=null;
            user.IsDeleted = true;

            await dbContext.SaveChangesAsync();
        }

        public async Task ReverseIsModeratorAsync(string userId)
        {
            var user = await dbContext
                .Users
                .Where(u => u.Id.ToString() == userId
                       && u.IsDeleted == false)
                .FirstAsync();

            user.IsModerator = !user.IsModerator;

            await dbContext.SaveChangesAsync();
        }
    }
}
