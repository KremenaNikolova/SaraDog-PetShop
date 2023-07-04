using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Data.Models;

namespace PetShop.Data.Configurations
{
    public class ApplicationUserItemConfiguration : IEntityTypeConfiguration<ApplicationUserItem>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserItem> builder)
        {
            builder
                .HasKey(ut=> new { ut.UserId, ut.ItemId });
        }
    }
}
