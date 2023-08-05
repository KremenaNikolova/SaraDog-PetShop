namespace PetShop.Services.Tests
{
    using PetShop.Data.Models;
    using PetShop.Web.Data;

    public static class DatabaseSeeder
    {
        public static ApplicationUser? User;

        public static Item? Item;
        public static Order? Order;
        public static Cart? Cart;
        public static CartItem? CartItem;


        public static void SeedDatabase(PetShopDbContext dbContext)
        {
            User = new ApplicationUser()
            {
                Id = Guid.Parse("7677f019-9433-48df-8e8b-1962d4952402"),
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@abv.bg",
                NormalizedEmail = "USER@ABV.BG",
                PasswordHash = "AQAAAAEAACcQAAAAELe8pVu/pYozNSb46Onf++v8jGIFZKhEXaIX0ajNLPc72g7IlIwIgqq5ERU1v4LoYQ==",
                ConcurrencyStamp = "1f21023a-57d9-45b1-8b25-add0035ce3c1",
                SecurityStamp = "SGOWNX4SXZ3DIQOGFWKIYXUJF6IYLSV3",
                FirstName = "Ivo",
                LastName = "Ivchev",
                Image = "catAvatar.jpg"
            };

            dbContext.Users.Add(User);

            Cart = new Cart()
            {
                Id = Guid.Parse("8D7572A5-4C6E-488F-AB8B-0AC01BF6D54A"),
                UserId = Guid.Parse("7677f019-9433-48df-8e8b-1962d4952402"),
                CreatedOn = DateTime.Parse("2023-07-28 10:04:42.2284039")
            };

            CartItem = new CartItem()
            {
                CartId = Guid.Parse("8D7572A5-4C6E-488F-AB8B-0AC01BF6D54A"),
                ItemId = 11,
                Quantity = 3
            };

            Cart.CartItems.Add(CartItem);

            dbContext.CartItems.Add(CartItem);
            dbContext.Carts.Add(Cart);

            Order = new Order()
            {
                Id = Guid.Parse("DEFA6A7F-A3EA-4DDF-945D-115F9CB7B246"),
                FirstName = "Kremena",
                LastName = "Nikolova",
                Country = "Bulgaria",
                City = "Test City",
                Address = "Test Address",
                PostCode = "Test 9932",
                CreatedOn = DateTime.Parse("2023-07-28 08:57:56.9627022"),
                UserId = Guid.Parse("7677f019-9433-48df-8e8b-1962d4952402"),
                CartId = Guid.Parse("8D7572A5-4C6E-488F-AB8B-0AC01BF6D54A"),
                TotalPrice = 29.55M
            };

            dbContext.Orders.Add(Order);

            dbContext.SaveChanges();
        }
    }
}
