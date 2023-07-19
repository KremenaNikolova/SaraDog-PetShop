namespace PetShop.Data.Configurations
{
    using System;
    
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    
    using PetShop.Data.Models;
    
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .HasOne(o=>o.User)
                .WithMany(u=>u.Orders)
                .HasForeignKey(o=>o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(o => o.TotalPrice)
                .HasPrecision(18, 2);
        }
    }
}
