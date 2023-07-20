namespace PetShop.Web.ViewModels.Category
{
    using System.ComponentModel.DataAnnotations;
    
    using PetShop.Web.ViewModels.Category.Enums;

    using static PetShop.Common.ApplicationConstants;
    
    public class AllCategoriesQueryModel
    {
        public AllCategoriesQueryModel()
        {
            CurrentPage = DefaultPage;
            ItemsPerPage = ItemsPerPageConstant;

            Categories = new HashSet<CategoryViewModel>();
        }

        [Display(Name = "Search by type")]
        public string? SearchString { get; set; }

        [Display(Name = "Sort By:")]
        public CategorySorting ItemSorting { get; set; }

        public int CurrentPage { get; set; }

        public int ItemsPerPage { get; set; }

        public int TotalItems { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
