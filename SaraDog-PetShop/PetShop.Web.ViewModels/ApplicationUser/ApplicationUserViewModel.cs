namespace PetShop.Web.ViewModels.ApplicationUser
{
    public class ApplicationUserViewModel
    {
        public string Id { get; set; } = null!;

        public string? UserName { get; set; } 

        public string? Email { get; set; }

        public string? Address { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsModerator { get; set; }

    }
}
