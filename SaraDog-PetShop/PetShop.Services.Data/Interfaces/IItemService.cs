namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Services.Data.Models.Item;
    using PetShop.Web.ViewModels.Item;

    public interface IItemService
    {
        Task<IEnumerable<ItemIndexViewModel>> GetAllItemsAsync();

        Task CreateItemAsync(ItemFormViewModel itemModel);

        Task<AllItemsFilteredAndPagedServiceModel> AllItemsAsync(AllItemsQueryModel queryModel);

        Task<ItemFormViewModel?> GetItemByIdAsync(int id);

        Task EditProductAsync(int id, ItemFormViewModel itemModel);

    }
}
