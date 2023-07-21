namespace PetShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.Migrations;

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

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

        public string? Address { get; set; }

        public string? PostCode { get; set; }

        public string? Image { get; set; }

        public bool IsModerator { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
