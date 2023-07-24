namespace PetShop.Services.Data.Models.User
{
    using PetShop.Web.ViewModels.User;

    public class AllUsersFilteredAndPagedServiceModel
    {
        public AllUsersFilteredAndPagedServiceModel()
        {
            Users = new HashSet<UserViewModel>();
        }
        public int TotalUsersCount { get; set; }

        public IEnumerable<UserViewModel> Users { get; set; }
    }
}
