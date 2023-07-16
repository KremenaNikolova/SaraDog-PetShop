namespace PetShop.Web.ViewModels.ApplicationUser
{
    public class ApplicationUserViewModel
    {
        public string Id { get; set; } = null!;

        public string? UserName { get; set; } 

        public string? Email { get; set; }

        public bool IsManager { get; set; }

    }
}
