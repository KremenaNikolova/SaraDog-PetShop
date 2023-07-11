namespace PetShop.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualBasic;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Category;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CategoryService : ICategoryService
    {
        private readonly PetShopDbContext dbContext;

        public CategoryService(PetShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<ItemCategoryViewModel>> AllCteagoriesAsync()
        {
            var allCategories = await dbContext
                .Categories
                .AsNoTracking()
                .Select(c => new ItemCategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            return allCategories;
        }

        public async Task<bool> IsCategoryExistAsync(int id)
        {
            var isIdExist = await dbContext
                .Categories
                .AnyAsync(c => c.Id == id);

            return isIdExist;
        }
    }
}
