namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Services.Data.Models.Category;
    using PetShop.Web.ViewModels.Category;

    public interface ICategoryService
    {
        Task<ICollection<CategoryViewModel>> AllCateagoriesAsync();

        Task<bool> IsCategoryExistAsync(int id);

        Task<IEnumerable<string>> AllCategoriesNameAsync();
        
        Task<bool> IsCategoryExistByNameAsync(string categoryName);

        Task CreateNewCategoryAsync(NewCategoryViewModel categoryModel);

        Task<AllCategoriesFilteredAndPagedServiceModel> AllCategoriesQueryAsync(AllCategoriesQueryModel queryModel);

        Task<NewCategoryViewModel> GetCategoryByIdAsync(int categoryId);

        Task EditCategoryAsync(int cateogryId, NewCategoryViewModel categoryModel);

        Task SoftDeleteCategoryAsync(int categoryId);
    }
}
