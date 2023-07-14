namespace PetShop.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Hosting;

    using PetShop.Data.Models;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Item;
    using PetShop.Services.Data.Models.Item;
    using PetShop.Web.ViewModels.Item.Enums;
    using PetShop.Web.ViewModels.Category;

    public class ItemService : IItemService
    {
        private readonly PetShopDbContext dbContext;
        private readonly IHostEnvironment environment;

        public ItemService(PetShopDbContext dbContext, IHostEnvironment environment)
        {
            this.dbContext = dbContext;
            this.environment = environment;
        }


        public async Task<IEnumerable<ItemIndexViewModel>> GetAllItemsAsync()
        {
            var allItems = await dbContext
                .Items
                .OrderByDescending(i => i.AddedOn)
                .Select(i => new ItemIndexViewModel
                {
                    Id = i.Id,
                    Title = i.Title,
                    Image = i.TitleImage,
                    Price = i.Price,
                })
                .ToArrayAsync();

            return allItems;
        }


        public async Task CreateItemAsync(ItemFormViewModel itemModel)
        {
            Item newItem = new Item()
            {
                Title = itemModel.Title,
                Description = itemModel.Description,
                TitleImage = itemModel.UploadPicture,
                Price = itemModel.Price,
                CategoryId = itemModel.CategoryId
            };

            await this.dbContext.AddAsync(newItem);
            await this.dbContext.SaveChangesAsync();

        }

        public async Task<AllItemsFilteredAndPagedServiceModel> AllItemsAsync(AllItemsQueryModel queryModel)
        {
            IQueryable<Item> itemsQuery = this.dbContext
                .Items
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.Category))
            {
                itemsQuery = itemsQuery
                    .Where(i => i.Category.Name == queryModel.Category);
            }

            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";

                itemsQuery = itemsQuery
                    .Where(i => EF.Functions.Like(i.Title, wildCard) ||
                                EF.Functions.Like(i.TitleImage, wildCard) ||
                                EF.Functions.Like(i.Description, wildCard));
            }

            itemsQuery = queryModel.ItemSorting switch
            {
                ItemSorting.Newest => itemsQuery
                    .OrderByDescending(i => i.AddedOn),
                ItemSorting.Oldest => itemsQuery
                    .OrderBy(i => i.AddedOn),
                ItemSorting.PriceAscending => itemsQuery
                    .OrderBy(i => i.Price),
                ItemSorting.PriceDescending => itemsQuery
                    .OrderByDescending(i => i.Price),
                _ => itemsQuery
                    .OrderByDescending(i => i.AddedOn)
            };

            IEnumerable<ItemIndexViewModel> searchedItems = await itemsQuery
                .Where(i=>i.isActive)
                .Skip((queryModel.CurrentPage - 1) * queryModel.ItemsPerPage)
                .Take(queryModel.ItemsPerPage)
                .Select(i => new ItemIndexViewModel()
                {
                    Id = i.Id,
                    Title = i.Title,
                    Price = i.Price,
                    Image = i.TitleImage

                })
                .ToArrayAsync();

            int totalItems = itemsQuery.Count();

            return new AllItemsFilteredAndPagedServiceModel()
            {
                TotalItemsCount = totalItems,
                Items = searchedItems
            };
        }

        public async Task<ItemFormViewModel?> GetItemByIdAsync(int itemId)
        {
            var categories = await dbContext
                .Categories
                .Select(c => new ItemCategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Image = c.Image
                })
                .ToListAsync();


            var currItem = await dbContext
                .Items
                .Where(i => i.Id == itemId)
                .Select(i => new ItemFormViewModel()
                {
                    Title = i.Title,
                    Description = i.Description,
                    Price = i.Price,
                    UploadPicture = i.TitleImage,
                    CategoryId = i.CategoryId,
                    Categories = categories
                })
                .FirstOrDefaultAsync();

            return currItem;
        }

        public async Task EditProductAsync(int itemId, ItemFormViewModel itemModel)
        {
            var currItem = await dbContext
                .Items
                .FindAsync(itemId);

            if(currItem != null)
            {
                currItem.Title = itemModel.Title;
                currItem.Description = itemModel.Description;
                currItem.Price = itemModel.Price;
                currItem.TitleImage = itemModel.UploadPicture;
                currItem.CategoryId = itemModel.CategoryId;
                currItem.LastEdit = DateTime.UtcNow;

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ItemIndexViewModel>> GetAllItemsInFavoritesAsync(string userId)
        {
            IEnumerable<ItemIndexViewModel> favorites = await dbContext
                .UserItems
                .Where(ui => ui.UserId.ToString() == userId)
                .Select(ui => new ItemIndexViewModel()
                {
                    Id = ui.Item.Id,
                    Title = ui.Item.Title,
                    Image = ui.Item.TitleImage,
                    Description = ui.Item.Description,
                    Price = ui.Item.Price,
                    Category = ui.Item.Category.Name
                })
                .ToArrayAsync();

            return favorites;
        }

        public async Task<ItemIndexViewModel?> GetDetailsByIdAsync(int itemId)
        {
            Item? item = await dbContext
                .Items
                .Include(i => i.Category)
                .Where(i=>i.Id == itemId && i.isActive == true)
                .FirstOrDefaultAsync();

            ItemIndexViewModel? itemModel = new ItemIndexViewModel()
            {
                Id= item!.Id,
                Title = item.Title,
                Description = item.Description,
                Price = item.Price,
                Category = item.Category.Name,
                Image = item.TitleImage
            };

            return itemModel;
        }

    }
}
