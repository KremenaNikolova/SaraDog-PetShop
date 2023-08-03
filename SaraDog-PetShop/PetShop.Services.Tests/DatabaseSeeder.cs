namespace PetShop.Services.Tests
{
    using PetShop.Data.Models;
    using PetShop.Web.Data;

    public static class DatabaseSeeder
    {
        public static ApplicationUser User;
        public static ApplicationUser Moderator;
        public static ApplicationUser Admin;

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
            Moderator = new ApplicationUser()
            {
                Id = Guid.Parse("cc0016fe-444a-439c-89a0-bb429e335424"),
                UserName = "moderator",
                NormalizedUserName = "MODERATOR",
                Email = "moderator@abv.bg",
                NormalizedEmail = "MODERATOR@ABV.BG",
                PasswordHash = "AQAAAAEAACcQAAAAEDbuBwp4bUNIe3gbNHJG2z/+N0Atz1V78mvAvoNqwTmK3QaRrKErB2gtlzP9wDtBdA==",
                ConcurrencyStamp = "062fe786-f8a1-4859-bbdc-154188ea4903",
                SecurityStamp = "NQ5CLPQ3KBRVFNANHXZ3SWC7FMEZ4DLX",
                FirstName = "Ganka",
                LastName = "Dimitrova",
                Image = "catAvatar.jpg"
            };
            Admin = new ApplicationUser()
            {
                Id = Guid.Parse("e48319dd-7b81-4af4-af33-a60dd1142fc9"),
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "administrator@abv.bg@renters.com",
                NormalizedEmail = "ADMINISTRATOR@ABV.BG",
                PasswordHash = "AQAAAAEAACcQAAAAEIc+k1oo/tc5Z8HNA5in13x2OqTb69TIOidRPdSq0nB8qd/D9uZjUhV2Orz2SS4nFg==",
                ConcurrencyStamp = "b05030f5-bc0e-4d04-89e5-636c4991c781",
                SecurityStamp = "P7DFJ32ALZG3YM6YHURCKFO4CHMIEXMU",
                FirstName = "Kremena",
                LastName = "Nikolova",
                Image = "LazyBum.jpg"
            };

            dbContext.Users.Add(User);
            dbContext.Users.Add(Moderator);
            dbContext.Users.Add(Admin);

            dbContext.SaveChanges();
        }
    }
}
