namespace PetShop.Services.Data.Interfaces
{
    using Microsoft.AspNetCore.Http;
    using PetShop.Web.ViewModels.Home;
    using PetShop.Web.ViewModels.Item;

    public interface IItemService
    {
        Task<IEnumerable<IndexViewModel>> GetAllItemsAsync();

        Task CreateItemAsync(ItemFormViewModel itemModel);


    }
}
