namespace PetShop.Web.ViewModels.ApplicationUser
{
    using System.ComponentModel.DataAnnotations;
    
    using PetShop.Web.ViewModels.ApplicationUser.Enums;
    using static PetShop.Common.ApplicationConstants;

    public class AllUsersQueryModel
    {
        public AllUsersQueryModel()
        {
            CurrentPage = DefaultPage;
            UsersPerPage = ItemsPerPageConstant;

            Users = new HashSet<ApplicationUserViewModel>();
        }

        [Display(Name = "Search by type")]
        public string? SearchString { get; set; }

        [Display(Name = "Sort By:")]
        public UsersSorting ItemSorting { get; set; }

        public int CurrentPage { get; set; }

        public int UsersPerPage { get; set; }

        public int TotalUsers { get; set; }

        public IEnumerable<ApplicationUserViewModel> Users { get; set; }
    }
}
