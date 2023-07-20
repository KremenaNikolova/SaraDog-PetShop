namespace PetShop.Web.ViewModels.Order
{
    using System.ComponentModel.DataAnnotations;

    using static PetShop.Common.ValidationConstants.OrderValidations;
    using static PetShop.Common.ErrorMessages.OrderErrorMessages;

    public class OrderFormViewModel
    {
        public string? Id { get; set; }

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = InvalidFirstName)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = InvalidLastName)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(CountryMaxLength, MinimumLength = CountryMinLength, ErrorMessage = InvalidCity)]
        public string Country { get; set; } = null!;

        [Required]
        [StringLength(CityMaxLenght, MinimumLength = CityMinLenght, ErrorMessage = InvalidCountry)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength, ErrorMessage = InvalidAddress)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(PostCodeMaxLength, MinimumLength = PostCodeMinLength, ErrorMessage = InvalidPostCode)]
        public string PostCode { get; set; } = null!;

        [StringLength(DescriptionMaxLength, ErrorMessage = InvalidDescripion)]
        public string? Description { get; set; }

        public string? UserId { get; set; }

        public string? CartId { get; set; } 

        public decimal TotalPrice { get; set; }
    }
}
