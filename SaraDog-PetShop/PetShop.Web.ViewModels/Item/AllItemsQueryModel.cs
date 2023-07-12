namespace PetShop.Web.ViewModels.Item
{
    using PetShop.Web.ViewModels.Item.Enums;
    using System.ComponentModel.DataAnnotations;
    using static PetShop.Common.ApplicationConstants;

    /// <summary>
    /// this is the model whom will hold the information which we will use for search
    /// </summary>
    public class AllItemsQueryModel 
    {
        public AllItemsQueryModel()
        {
            this.CurrentPage = DefaultPage;
            this.ItemsPerPage = ItemsPerPageConstant;

            this.Categories = new HashSet<string>();
            this.Items = new HashSet<ItemSearchViewModel>();
        }

        [Display(Name = "Категория")]
        public string? Category { get; set; }

        [Display(Name = "Търси по дума")]
        public string? SearchString { get; set; }

        [Display(Name = "Сортирай по:")]
        public ItemSorting ItemSorting { get; set; }

        public int CurrentPage { get; set; }

        public int ItemsPerPage { get; set; }

        public int TotalItems { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public IEnumerable<ItemSearchViewModel> Items { get; set; }
    }
}
