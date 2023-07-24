namespace PetShop.Web.ViewModels.Category
{
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    using static PetShop.Common.ValidationConstants.CategoryValidation;
    using static PetShop.Common.ErrorMessages.CategoryErrorMessages;

    public class NewCategoryViewModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength =NameMinLength, ErrorMessage = InvalidName)]
        public string Name { get; set; } = null!;

        [Required]
        public string Image { get; set; } = null!;

        public IFormFile? ImageFile { get; set; }
    }
}
