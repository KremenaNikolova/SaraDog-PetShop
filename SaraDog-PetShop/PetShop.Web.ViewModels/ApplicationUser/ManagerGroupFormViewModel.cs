namespace PetShop.Web.ViewModels.ApplicationUser
{
    using PetShop.Web.ViewModels.Category;
    using PetShop.Web.ViewModels.Item;

    public class ManagerGroupFormViewModel
    {
        public ManagerGroupFormViewModel()
        {
            Items = new HashSet<ItemIndexViewModel>();
            Categories = new HashSet<CategoryViewModel>();
            Users = new HashSet<ApplicationUserViewModel>();
        }

        public IEnumerable<ApplicationUserViewModel> Users { get; set; }

        public IEnumerable<ItemIndexViewModel> Items { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
