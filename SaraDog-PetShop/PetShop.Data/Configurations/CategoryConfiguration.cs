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
                Image = "DressCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Нашийници, Нагръдници и Поводи",
                Image = "CollarCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Играчки",
                Image = "ToyCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Транспортни клетки",
                Image = "TravellingCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "Легла",
                Image = "SleepingPad.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 6,
                Name = "Пелени и подложки",
                Image = "HygienicPad.jpg"
            };
            categories.Add(category);


            category = new Category()
            {
                Id = 7,
                Name = "Грижа за козината",
                Image = "ShortGroomingCloserCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 8,
                Name = "Купички за храна и вода",
                Image = "DressCategory.jpg"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
