namespace PetShop.Web.ViewModels.Order
{
    using System.ComponentModel.DataAnnotations;
    
    using PetShop.Web.ViewModels.Cart;

    public class OrderHistoryViewModel
    {
        public OrderHistoryViewModel()
        {
            CartItems = new HashSet<CartItemViewModel>();    
        }

        [Required]
        public string Id { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public decimal TotalPrice { get; set; }

        public IEnumerable<CartItemViewModel> CartItems { get; set; }

    }
}
