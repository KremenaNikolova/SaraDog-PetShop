namespace PetShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    
    using Microsoft.AspNetCore.Identity;

    using static PetShop.Common.ValidationConstants.UserValidations;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();

            IsModerator = false;
            IsDeleted = false;

            CreatedOn = DateTime.UtcNow;

            Orders = new HashSet<Order>();
        }

        [MaxLength(FirstNameMaxLength)]
        public string? FirstName { get; set; }

        [MaxLength(LastNameMaxLength)]
        public string? LastName { get; set; }

        [MaxLength(CountryMaxLength)]
        public string? Country { get; set; }

        [MaxLength(CityMaxLength)]
        public string? City { get; set; }

        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; }

        [MaxLength(PostCodeMaxLength)]
        public string? PostCode { get; set; }

        public string? Image { get; set; }

        public bool IsModerator { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
