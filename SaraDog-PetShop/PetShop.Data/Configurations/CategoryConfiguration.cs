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
                Name = "Clothing",
                Image = "DressCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Leads and Collars",
                Image = "CollarCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Toys",
                Image = "ToyCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Travelling Crates and Bags",
                Image = "TravellingCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "Beds and Sleeping",
                Image = "SleepingPad.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 6,
                Name = "Hygienic Pads",
                Image = "HygienicPad.jpg"
            };
            categories.Add(category);


            category = new Category()
            {
                Id = 7,
                Name = "Grooming",
                Image = "ShortGroomingCloserCategory.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 8,
                Name = "Food and Water Bowls",
                Image = "DressCategory.jpg"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
