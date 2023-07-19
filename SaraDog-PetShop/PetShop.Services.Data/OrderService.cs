using PetShop.Services.Data.Interfaces;

namespace PetShop.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using PetShop.Data.Models;
    using PetShop.Web.Data;
    using PetShop.Web.ViewModels.Order;

    public class OrderService : IOrderService
    {
        private readonly PetShopDbContext dbContext;
        public OrderService(PetShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<OrderFormViewModel?> GetOrderDetailsAsync(string cartId)
        {
            var order = await dbContext
                .Orders
                .Where(o=>o.CartId.ToString()==cartId)
                .Select(o=> new OrderFormViewModel()
                {
                    Id=o.Id.ToString(),
                    FirstName = o.FirstName!,
                    LastName = o.LastName!,
                    Country = o.Country!,
                    City = o.City!,
                    Address = o.Address!,
                    PostCode = o.PostCode!,
                    CartId = cartId,
                    TotalPrice = o.TotalPrice
                })
                .FirstOrDefaultAsync();

            return order;
        }

        public async Task CreateOrder(OrderFormViewModel orderModel)
        {
            Guid validCartId;
            Guid validUserId;

            bool isValidCartId = Guid.TryParse(orderModel.CartId, out validCartId);
            bool isValidUserId = Guid.TryParse(orderModel.UserId, out validUserId);

            if (isValidCartId && isValidUserId)
            {
                Order order = new Order()
                {
                    FirstName = orderModel.FirstName,
                    LastName = orderModel.LastName,
                    Country = orderModel.Country,
                    City = orderModel.City,
                    Address = orderModel.Address,
                    PostCode = orderModel.PostCode,
                    CartId = validCartId,
                    UserId = validUserId,
                    TotalPrice= orderModel.TotalPrice
                };

                await dbContext.Orders.AddAsync(order);
                await dbContext.SaveChangesAsync();
            }
            
        }
    }
}
