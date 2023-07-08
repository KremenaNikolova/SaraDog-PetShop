namespace PetShop.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Home;

    public class ItemService : IItemService
    {
        private readonly PetShopDbContext dbContext;

        public ItemService(PetShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexViewModel>> GetAllItemsAsync()
        {
            var allItems = await dbContext
                .Items
                .OrderByDescending(i=>i.AddedOn)
                .Select(i => new IndexViewModel
                {
                    Id = i.Id,
                    Title = i.Title,
                    Image = i.TitleImage,
                    Price = i.Price,
                })
                .ToArrayAsync();

            return allItems;
        }
    }
}
