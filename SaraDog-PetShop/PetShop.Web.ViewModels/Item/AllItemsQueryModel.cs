﻿namespace PetShop.Web.ViewModels.Item
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
            CurrentPage = DefaultPage;
            ItemsPerPage = ItemsPerPageConstant;

            Categories = new HashSet<string>();
            Items = new HashSet<ItemIndexViewModel>();
        }

        public string? Category { get; set; }

        [Display(Name = "Search by type")]
        public string? SearchString { get; set; }

        [Display(Name = "Sort By:")]
        public ItemSorting ItemSorting { get; set; }

        public int CurrentPage { get; set; }

        public int ItemsPerPage { get; set; }

        public int TotalItems { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public IEnumerable<ItemIndexViewModel> Items { get; set; }
    }
}
