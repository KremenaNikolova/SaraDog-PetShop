namespace PetShop.Web.ViewModels.Cart
{
    using PetShop.Web.ViewModels.Item;

    public class CartFormViewModel
    {
        public CartFormViewModel()
        {
            Items = new HashSet<CartItemViewModel>();
        }

        public decimal TotalPrice { get; set; }
        public IEnumerable<CartItemViewModel> Items { get; set; }
    }
}
