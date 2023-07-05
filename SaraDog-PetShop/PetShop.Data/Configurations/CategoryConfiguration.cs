namespace PetShop.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    
    using PetShop.Data.Models;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category()
            {
                Id = 1,
                Name = "Дрехи",
                IsDeleted = false
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Нашийници, Нагръдници и Поводи",
                IsDeleted = false
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Играчки",
                IsDeleted = false
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Транспортни клетки",
                IsDeleted = false
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "Легла",
                IsDeleted = false
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 6,
                Name = "Пелени и подложки",
                IsDeleted = false
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 7,
                Name = "Грижа за козината",
                IsDeleted = false
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 8,
                Name = "Купички за храна и вода",
                IsDeleted = false
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
