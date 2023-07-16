namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Web.ViewModels.ApplicationUser;

    public interface IUserService
    {
        Task<IEnumerable<ApplicationUserViewModel>> GetAllUsersAsync();

    }
}
