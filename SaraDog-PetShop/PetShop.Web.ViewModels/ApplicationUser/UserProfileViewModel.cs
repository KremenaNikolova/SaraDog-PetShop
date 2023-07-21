namespace PetShop.Web.ViewModels.ApplicationUser
{
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public class UserProfileViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        public string? UserName { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set;}

        public string? Country { get; set; }

        public string? City { get; set; }

        public string? Address { get; set; }

        public string? PostCode { get; set; }

        public string? Image { get; set; }

        public IFormFile? FormImage { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
