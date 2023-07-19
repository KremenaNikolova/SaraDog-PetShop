namespace PetShop.Web.ViewModels.Cart
{
    using System.ComponentModel.DataAnnotations;
    using static PetShop.Common.ValidationConstants.CartValidations;

    public class CartItemViewModel
    {
        public CartItemViewModel()
        {
            Quantity = 0;
            TotalPrice = Price * Quantity;
        }
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public decimal Price { get; set; }

        [Range(typeof(int), QuantityMinValue, QuantityMaxValue)]
        public int Quantity { get; set; }

        [Range(typeof(decimal), TotalPriceMinValue, TotalPriceMaxValue)]
        public decimal TotalPrice { get; set; }
    }
}
