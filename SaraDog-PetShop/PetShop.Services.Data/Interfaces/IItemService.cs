﻿namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Services.Data.Models.Item;
    using PetShop.Web.ViewModels.Item;

    public interface IItemService
    {
        Task<IEnumerable<ItemIndexViewModel>> GetAllItemsAsync();

        Task CreateItemAsync(ItemFormViewModel itemModel);

        Task<AllItemsFilteredAndPagedServiceModel> AllItemsAsync(AllItemsQueryModel queryModel);

        Task<ItemFormViewModel?> GetItemByIdAsync(int itemId);

        Task EditProductAsync(int id, ItemFormViewModel itemModel);

        Task<IEnumerable<ItemIndexViewModel>> GetAllItemsInFavorites(string userId);

        Task<ItemIndexViewModel?> GetDetailsByIdAsync(int itemId);

    }
}
