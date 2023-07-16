﻿namespace PetShop.Services.Data.Interfaces
{
    using PetShop.Web.ViewModels.Category;
    using System.Collections.ObjectModel;

    public interface ICategoryService
    {
        Task<ICollection<CategoryViewModel>> AllCteagoriesAsync();

        Task<bool> IsCategoryExistAsync(int id);

        Task<IEnumerable<string>> AllCategoriesNameAsync();
    }
}
