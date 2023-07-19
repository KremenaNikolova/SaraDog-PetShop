namespace PetShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
            IsManager = false;

            Orders = new HashSet<Order>();
        }

        public string? Address { get; set; }

        public bool IsManager { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
