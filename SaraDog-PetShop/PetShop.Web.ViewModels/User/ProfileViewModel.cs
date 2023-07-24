namespace PetShop.Web.ViewModels.User
{
    using System.ComponentModel.DataAnnotations;
    
    using Microsoft.AspNetCore.Http;


    public class ProfileViewModel
    {
        [Required]
        public string UserName { get; set; } = null!;

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

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
