namespace PetShop.Web.ViewModels.Category
{
    using Microsoft.AspNetCore.Http;

    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Image { get; set; }

        public IFormFile? ImageFile { get; set; }
    }
}
