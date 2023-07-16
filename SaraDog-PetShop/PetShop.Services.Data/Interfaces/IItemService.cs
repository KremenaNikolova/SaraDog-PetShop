namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Services.Data.Models.Item;
    using PetShop.Web.ViewModels.Item;

    public interface IItemService
    {
        Task<IEnumerable<ItemIndexViewModel>> GetAllIActivetemsAsync();

        Task CreateItemAsync(ItemFormViewModel itemModel);

        Task<AllItemsFilteredAndPagedServiceModel> AllActiveItemsQueryAsync(AllItemsQueryModel queryModel);

        Task<AllItemsFilteredAndPagedServiceModel> AllIVisibletemsQueryAsync(AllItemsQueryModel queryModel);

        Task<ItemFormViewModel> GetItemByIdAsync(int itemId);

        Task EditProductAsync(int id, ItemFormViewModel itemModel);

        Task<IEnumerable<ItemIndexViewModel>> GetAllItemsInFavoritesAsync(string userId);

        Task<ItemIndexViewModel> GetDetailsByIdAsync(int itemId);

        Task SoftDeleteItemAsync(int itemId);


    }
}
