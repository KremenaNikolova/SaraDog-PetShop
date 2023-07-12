namespace PetShop.Web.ViewModels.Item
{
    public class ItemIndexViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Image { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
