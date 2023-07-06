namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Web.ViewModels.Home;

    public interface IShopService
    {
        Task<IEnumerable<IndexViewModel>> GetAllItemsAsync();
    }
}
