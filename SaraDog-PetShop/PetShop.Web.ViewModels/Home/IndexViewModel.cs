namespace PetShop.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Image { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
