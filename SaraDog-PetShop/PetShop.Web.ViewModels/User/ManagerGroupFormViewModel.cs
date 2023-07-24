namespace PetShop.Web.ViewModels.User
{
    using PetShop.Web.ViewModels.Category;
    using PetShop.Web.ViewModels.Item;

    public class ManagerGroupFormViewModel
    {
        public ManagerGroupFormViewModel()
        {
            Items = new HashSet<ItemIndexViewModel>();
            Categories = new HashSet<CategoryViewModel>();
            Users = new HashSet<UserViewModel>();
        }

        public IEnumerable<UserViewModel> Users { get; set; }

        public IEnumerable<ItemIndexViewModel> Items { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
