namespace PetShop.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetShop.Data.Models;


    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder
                .HasOne(i=>i.Category)
                .WithMany(i=>i.Items)
                .HasForeignKey(i=>i.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(i=>i.Buyer)
                .WithMany(i=>i.Items)
                .HasForeignKey(i=>i.BuyerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(i => i.Price)
                .HasPrecision(18, 4);
        }
    }
}
