namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Services.Data.Models.User;
    using PetShop.Web.ViewModels.ApplicationUser;

    public interface IUserService
    {
        Task<IEnumerable<ApplicationUserViewModel>> GetAllUsersAsync();
        Task<AllUsersFilteredAndPagedServiceModel> AllUsersQueryAsync(AllUsersQueryModel queryModel);


    }
}
