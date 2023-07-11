namespace PetShop.Services.Data
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Hosting;

    using Azure.Storage.Blobs;
    using Azure.Storage.Blobs.Models;

    using PetShop.Data.Models;
    using PetShop.Services.Data.Interfaces;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Home;
    using PetShop.Web.ViewModels.Item;
    using Azure.Core;
    using Azure.Core.Pipeline;

    public class ItemService : IItemService
    {
        private readonly PetShopDbContext dbContext;
        private readonly IHostEnvironment environment;

        public ItemService(PetShopDbContext dbContext, IHostEnvironment environment)
        {
            this.dbContext = dbContext;
            this.environment = environment;
        }


        public async Task<IEnumerable<IndexViewModel>> GetAllItemsAsync()
        {
            var allItems = await dbContext
                .Items
                .OrderByDescending(i => i.AddedOn)
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

    }
}
