namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Services.Data.Models.Category;
    using PetShop.Web.ViewModels.Category;
    using PetShop.Web.ViewModels.Item;

    public interface ICategoryService
    {
        Task<ICollection<CategoryViewModel>> AllCteagoriesAsync();

        Task<bool> IsCategoryExistAsync(int id);

        Task<IEnumerable<string>> AllCategoriesNameAsync();

        Task<IEnumerable<ItemIndexViewModel>> AllItemsByChooseCateryAsync(int categoryId);

        Task<bool> IsCategoryExistByNameAsync(string categoryName);

        Task CreateNewCategoryAsync(NewCategoryViewModel categoryModel);

        Task<AllCategoriesFilteredAndPagedServiceModel> AllCategoriesQueryAsync(AllCategoriesQueryModel queryModel);

        Task<NewCategoryViewModel> GetCategoryByIdAsync(int categoryId);

        Task EditProductAsync(int cateogryId, NewCategoryViewModel categoryModel);
    }
}
