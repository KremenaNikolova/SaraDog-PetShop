namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Web.ViewModels.Category;
    using System.Collections.ObjectModel;

    public interface ICategoryService
    {
        Task<ICollection<ItemCategoryViewModel>> AllCteagoriesAsync();
    }
}
