namespace PetShop.Web.ViewModels.Item
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    using PetShop.Web.ViewModels.Category;

    using static PetShop.Common.ValidationConstants.ItemValidationConstants;
    using static PetShop.Common.ErrorMessages.TitleErrorMessages;

    public class ItemFormViewModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = InvalidTitle)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = InvalidDescription)]
        public string Description { get; set; } = null!;

        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = InvalidPrice)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Choose Image")]
        public string UploadPicture { get; set; } = null!;

        public IFormFile? ImageFile { get; set; }

        public int CategoryId { get; set; }

        public virtual ICollection<CategoryViewModel> Categories { get; set; } = new HashSet<CategoryViewModel>();

    }
}
