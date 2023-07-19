namespace PetShop.Web.ViewModels.Cart
{
    using System.ComponentModel.DataAnnotations;
    
    using static PetShop.Common.ValidationConstants.CartValidations;

    public class CartFormViewModel
    {
        public CartFormViewModel()
        {
            Items = new HashSet<CartItemViewModel>();
            TotalPrice = 0;
        }
        public string Id { get; set; } = null!;

        [Range(typeof(decimal), TotalPriceMinValue, TotalPriceMaxValue)]
        public decimal TotalPrice { get; set; }

        public IEnumerable<CartItemViewModel> Items { get; set; }
    }
}
