namespace PetShop.Services.Data.Models.Category
{
    using PetShop.Web.ViewModels.Category;

    public class AllCategoriesFilteredAndPagedServiceModel
    {
        public AllCategoriesFilteredAndPagedServiceModel()
        {
            Categories = new HashSet<CategoryViewModel>();
        }

        public int TotalCategoriesCount { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
