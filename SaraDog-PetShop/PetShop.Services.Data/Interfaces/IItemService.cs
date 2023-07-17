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

        Task AddToFavouritesAsync(string userId, int itemId);

        bool IsAlreadyAddedAsync(string userId, int itemId);

        Task<ItemIndexViewModel> GetDetailsByIdAsync(int itemId);

        Task SoftDeleteItemAsync(int itemId);
        
        Task TurnActivityAsync(int itemId);
    }
}
