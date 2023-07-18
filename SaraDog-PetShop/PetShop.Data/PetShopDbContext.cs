namespace PetShop.Web.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    
    using PetShop.Data.Models;
    using System.Reflection;

    public class PetShopDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<ApplicationUserItem> UserItems { get; set; } = null!;

        public DbSet<Cart> Carts { get; set; } = null!;

        public DbSet<CartItem> CartItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var configAssembly = Assembly.GetAssembly(typeof(PetShopDbContext));
                                 Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(configAssembly!);

            base.OnModelCreating(builder);
        }
    }
}