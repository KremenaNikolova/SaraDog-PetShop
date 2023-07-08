namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Web.ViewModels.Home;

    public interface IItemService
    {
        Task<IEnumerable<IndexViewModel>> GetAllItemsAsync();
    }
}
