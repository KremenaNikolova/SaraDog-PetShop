namespace PetShop.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PetShop.Data.Models;

    public class ApplicationUserItemConfiguration : IEntityTypeConfiguration<ApplicationUserItem>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserItem> builder)
        {
            builder
                .HasKey(ut => new { ut.UserId, ut.ItemId });
        }

    }
}
