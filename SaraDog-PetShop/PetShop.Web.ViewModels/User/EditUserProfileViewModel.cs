namespace PetShop.Web.ViewModels.User
{
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    using static PetShop.Common.ValidationConstants.UserValidations;
    using static PetShop.Common.ErrorMessages.UserErrorMessage;

    public class EditUserProfileViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(UsernameMaxLength, MinimumLength = UsernameMinLength, ErrorMessage = InvalidUsername)]
        public string UserName { get; set; } = null!;

        public string? FirstName { get; set; }

        public string? LastName { get; set;}

        public string? Country { get; set; }

        public string? City { get; set; }

        public string? Address { get; set; }

        public string? PostCode { get; set; }

        public string? Image { get; set; }

        public IFormFile? FormImage { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}
