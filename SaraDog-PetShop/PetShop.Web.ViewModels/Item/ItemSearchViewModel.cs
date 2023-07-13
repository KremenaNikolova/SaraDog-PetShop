namespace PetShop.Web.ViewModels.Item
{
    using System.ComponentModel.DataAnnotations;

    public class ItemSearchViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        public decimal Price { get; set; }

        [Required]
        public string Image { get; set; } = null!;

    }
}
