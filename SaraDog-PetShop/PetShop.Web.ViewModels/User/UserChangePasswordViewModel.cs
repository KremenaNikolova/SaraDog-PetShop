namespace PetShop.Web.ViewModels.User
{
    using System.ComponentModel.DataAnnotations;

    using static PetShop.Common.ErrorMessages.GeneralError;

    public class UserChangePasswordViewModel
    {
        [Required(ErrorMessage = GeneralRequiredErrorMessage)]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; } = null!;

        [Required(ErrorMessage = GeneralRequiredErrorMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; } = null!;

        [Required(ErrorMessage = GeneralRequiredErrorMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set;} = null!;
    }
}
