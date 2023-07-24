namespace PetShop.Web.ViewModels.User
{
    using System.ComponentModel.DataAnnotations;
    
    using PetShop.Web.ViewModels.User.Enums;
    using static PetShop.Common.ApplicationConstants;

    public class AllUsersQueryModel
    {
        public AllUsersQueryModel()
        {
            CurrentPage = DefaultPage;
            UsersPerPage = ItemsPerPageConstant;

            Users = new HashSet<UserViewModel>();
        }

        [Display(Name = "Search by type")]
        public string? SearchString { get; set; }

        [Display(Name = "Sort By:")]
        public UsersSorting ItemSorting { get; set; }

        public int CurrentPage { get; set; }

        public int UsersPerPage { get; set; }

        public int TotalUsers { get; set; }

        public IEnumerable<UserViewModel> Users { get; set; }
    }
}
