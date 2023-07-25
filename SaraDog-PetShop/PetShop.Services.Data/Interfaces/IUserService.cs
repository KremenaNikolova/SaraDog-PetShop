namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Services.Data.Models.User;
    using PetShop.Web.ViewModels.User;

    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> GetAllUsersAsync();

        Task<IEnumerable<UserViewModel>> GetAllUsersExceptCurrOneAsync(string userId);

        Task<AllUsersFilteredAndPagedServiceModel> AllUsersQueryAsync(AllUsersQueryModel queryModel);

        Task<EditUserProfileViewModel> GetUserByIdAsync(string userId);

        Task EditProfileAsync(string userId, EditUserProfileViewModel model);

        Task SoftDeleteUserAsync(string userId);

        Task ReverseIsModeratorAsync(string userId);
    }
}
