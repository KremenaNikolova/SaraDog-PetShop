namespace PetShop.Web.ViewModels.Shop
{
    using System.ComponentModel.DataAnnotations;
    
    using Microsoft.AspNetCore.Http;

    using PetShop.Web.ViewModels.Category;
    
    using static PetShop.Common.ValidationConstants.ItemValidationConstants;
    using static PetShop.Common.ErrorMessages.TitleErrorMessages;

    public class ItemFormViewModel
    {
        [Display(Name = "Заглавие")]
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = InvalidTitle)]
        public string Title { get; set; } = null!;

        [Display(Name = "Описание")]
        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = InvalidDescription)]
        public string Description { get; set; } = null!;

        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = InvalidPrice)]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required]
        [Display (Name = "Основна Снимка")]
        public IFormFile UploadPicture { get; set; } = null!;

        public int CategoryId { get; set; }

        [Display(Name = "Категории")]
        public virtual ICollection<ItemCategoryViewModel> Categories { get; set; } = new HashSet<ItemCategoryViewModel>();

    }
}
