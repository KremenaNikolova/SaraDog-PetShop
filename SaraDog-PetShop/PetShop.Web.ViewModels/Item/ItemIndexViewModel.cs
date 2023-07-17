namespace PetShop.Web.ViewModels.Item
{
    public class ItemIndexViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Image { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public string Category { get; set; } = null!;

        public bool? IsActive { get; set; }

    }
}
