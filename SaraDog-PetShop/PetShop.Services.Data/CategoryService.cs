namespace PetShop.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using PetShop.Data.Models;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Services.Data.Models.Category;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Category;
    using PetShop.Web.ViewModels.Category.Enums;
    using PetShop.Web.ViewModels.Item;


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
                .Where(c => c.IsDeleted == false)
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
                .Where(c => c.IsDeleted == false)
                .AnyAsync(c => c.Id == id);

            return isIdExist;
        }

        public async Task<IEnumerable<string>> AllCategoriesNameAsync()
        {
            IEnumerable<string> allNames = await dbContext
                .Categories
                .Where(c => c.IsDeleted == false)
                .Select(c => c.Name)
                .ToArrayAsync();

            return allNames;
        }

        public async Task<IEnumerable<ItemIndexViewModel>> AllItemsByChooseCateryAsync(int categoryId)
        {
            var allItems = await dbContext
                .Items
                .Where(i => i.CategoryId == categoryId && i.IsActive && i.Category.IsDeleted == false)
                .Select(i => new ItemIndexViewModel()
                {
                    Id = i.Id,
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
                .Where(c => c.IsDeleted == false)
                .AnyAsync(c => c.Name == categoryName);

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

        public async Task<AllCategoriesFilteredAndPagedServiceModel> AllCategoriesQueryAsync(AllCategoriesQueryModel queryModel)
        {
            IQueryable<Category> categoryQuery = dbContext
                .Categories
                .Where(c => c.IsDeleted == false)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";

                categoryQuery = categoryQuery
                    .Where(c => EF.Functions.Like(c.Name, wildCard) ||
                                EF.Functions.Like(c.Image, wildCard));
            }

            categoryQuery = queryModel.ItemSorting switch
            {
                CategorySorting.NameAscending => categoryQuery
                    .OrderBy(c => c.Name),
                CategorySorting.NameDescending => categoryQuery
                    .OrderByDescending(c => c.Name),
                CategorySorting.IdAscending => categoryQuery
                .OrderBy(c => c.Id),
                CategorySorting.IdDescending => categoryQuery
                .OrderByDescending(c => c.Id),
                _ => categoryQuery
                    .OrderBy(c => c.Id)
            };

            IEnumerable<CategoryViewModel> searchedCategories = await categoryQuery
                .Where(i => i.IsDeleted == false)
                .Skip((queryModel.CurrentPage - 1) * queryModel.ItemsPerPage)
                .Take(queryModel.ItemsPerPage)
                .Select(i => new CategoryViewModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Image = i.Image
                })
                .ToArrayAsync();

            int totalCategories = categoryQuery.Count();

            return new AllCategoriesFilteredAndPagedServiceModel()
            {
                TotalCategoriesCount = totalCategories,
                Categories = searchedCategories
            };
        }

        public async Task<NewCategoryViewModel> GetCategoryByIdAsync(int categoryId)
        {
            var category = await dbContext
                .Categories
                .Where(c => c.Id == categoryId && c.IsDeleted == false)
                .Select(c => new NewCategoryViewModel()
                {
                    Name = c.Name,
                    Image = c.Image
                })
                .FirstAsync();

            return category;
        }

        public async Task EditCategoryAsync(int cateogryId, NewCategoryViewModel categoryModel)
        {
            var currCategory = await dbContext
                .Categories
                .FindAsync(cateogryId);

            if (currCategory != null)
            {
                currCategory.Name = categoryModel.Name;
                currCategory.Image = categoryModel.Image;
                currCategory.IsDeleted = false;

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task SoftDeleteCategoryAsync(int categoryId)
        {
            Category category = await dbContext
                .Categories
                .Where(c => c.Id == categoryId)
                .FirstAsync();

            category.IsDeleted = true;

            await dbContext.SaveChangesAsync();
        }
    }
}
