using PetShop.Web.ViewModels.Category;

namespace PetShop.Services.Data.Models.Category
{
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
