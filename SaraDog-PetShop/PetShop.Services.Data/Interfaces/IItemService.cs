namespace PetShop.Services.Data.Interfaces
{
    using Microsoft.AspNetCore.Http;
    using PetShop.Services.Data.Models.Item;
    using PetShop.Web.ViewModels.Home;
    using PetShop.Web.ViewModels.Item;

    public interface IItemService
    {
        Task<IEnumerable<ItemIndexViewModel>> GetAllItemsAsync();

        Task CreateItemAsync(ItemFormViewModel itemModel);

        Task<AllItemsFilteredAndPagedServiceModel> AllItemsAsync(AllItemsQueryModel queryModel);

    }
}
