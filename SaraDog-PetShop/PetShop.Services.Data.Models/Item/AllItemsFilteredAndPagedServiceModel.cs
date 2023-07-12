namespace PetShop.Services.Data.Models.Item
{
    using PetShop.Web.ViewModels.Item;

    public class AllItemsFilteredAndPagedServiceModel
    {
        public AllItemsFilteredAndPagedServiceModel()
        {
            this.Items = new HashSet<ItemSearchViewModel>();
        }
        public int TotalItemsCount { get; set; }

        public IEnumerable<ItemSearchViewModel> Items { get; set; }
    }
}
