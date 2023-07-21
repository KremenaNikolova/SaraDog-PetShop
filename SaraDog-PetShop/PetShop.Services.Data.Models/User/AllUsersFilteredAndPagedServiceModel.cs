namespace PetShop.Services.Data.Models.User
{
    using PetShop.Web.ViewModels.ApplicationUser;

    public class AllUsersFilteredAndPagedServiceModel
    {
        public AllUsersFilteredAndPagedServiceModel()
        {
            Users = new HashSet<ApplicationUserViewModel>();
        }
        public int TotalUsersCount { get; set; }

        public IEnumerable<ApplicationUserViewModel> Users { get; set; }
    }
}
