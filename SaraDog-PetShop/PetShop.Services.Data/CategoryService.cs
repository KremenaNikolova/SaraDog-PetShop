namespace PetShop.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualBasic;
    using PetShop.Data.Models;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Category;
    using PetShop.Web.ViewModels.Item;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CategoryService : ICategoryService
    {
        private readonly PetShopDbContext dbContext;

        public CategoryService(PetShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<CategoryViewModel>> AllCteagoriesAsync()
        {
            var allCategories = await dbContext
                .Categories
                .AsNoTracking()
                .Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Image = c.Image
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

        public async Task<IEnumerable<string>> AllCategoriesNameAsync()
        {
            IEnumerable<string> allNames = await dbContext
                .Categories
                .Select(c => c.Name)
                .ToArrayAsync();

            return allNames;
        }

        public async Task<IEnumerable<ItemIndexViewModel>> AllItemsByChooseCateryAsync(int categoryId)
        {
            var allItems = await dbContext
                .Items
                .Where(i => i.CategoryId == categoryId && i.IsActive)
                .Select(i=> new ItemIndexViewModel()
                {
                    Id= i.Id,
                    Title = i.Title,
                    Image = i.TitleImage,
                    Description = i.Description,
                    Price = i.Price,
                    IsActive = i.IsActive,
                    Category = i.Category.Name
                })
                .ToArrayAsync();

            return allItems;
        }

        public async Task<bool> IsCategoryExistByNameAsync(string categoryName)
        {
            var isExist = await dbContext
                .Categories
                .AnyAsync(c=>c.Name == categoryName);

            return isExist;
        }

        public async Task CreateNewCategoryAsync(NewCategoryViewModel categoryModel)
        {
            Category category = new Category()
            {
                Name = categoryModel.Name,
                Image = categoryModel.Image
            };

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
        }
    }
}
