namespace PetShop.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PetShop.Data.Models;
    using System.Reflection;

    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder
                .HasOne(i => i.Category)
                .WithMany(i => i.Items)
                .HasForeignKey(i => i.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(i => i.Price)
                .HasPrecision(18, 2);

            builder
                .Property(i => i.Rating)
                .HasPrecision(18, 2);

            builder
                .HasData(this.GenerateItems());
        }

        private Item[] GenerateItems()
        {
            ICollection<Item> items = new HashSet<Item>();

            Item item;

            item = new Item()
            {
                Id = 1,
                Title = "Hoodie - Minions",
                TitleImage = "MinionDress.jpg",
                Description = "Yellow hoodie with minion motifs, size M, suitable for colder winter days.",
                Price = 25.50M,
                CategoryId = 1
            };
            items.Add(item);

            item = new Item()
            {
                Id = 2,
                Title = "Hoodie - Green bear",
                TitleImage = "GreenHoodie2.jpg",
                Description = "Green hoodie with bear motifs and eyelets on the hood, size M, suitable for colder winter days.",
                Price = 35.90M,
                CategoryId = 1
            };
            items.Add(item);

            item = new Item()
            {
                Id = 3,
                Title = "Top - Blue autumn",
                TitleImage = "BlueDress3.jpg",
                Description = "Thick blue blouse with bears and rose leaf motifs, size M.",
                Price = 20.30M,
                CategoryId = 1
            };
            items.Add(item);

            item = new Item()
            {
                Id = 4,
                Title = "Hoodie - Lilac",
                TitleImage = "PurpleHoodie.jpg",
                Description = "Purple clean hoodie with pocket, size M.",
                Price = 19.90M,
                CategoryId = 1
            };
            items.Add(item);

            item = new Item()
            {
                Id = 5,
                Title = "Top - Pink pajamas",
                TitleImage = "PinkDress2.jpg",
                Description = "A thick pink blouse that looks like a cute pajama, size M, perfect for colder winter days.",
                Price = 20.30M,
                CategoryId = 1
            };
            items.Add(item);

            item = new Item()
            {
                Id = 6,
                Title = "Ice cream",
                TitleImage = "IceCream.jpg",
                Description = "Plush ice cream, with a push button and a rope on the top.",
                Price = 10.10M,
                CategoryId = 3
            };
            items.Add(item);

            item = new Item()
            {
                Id = 7,
                Title = "Octopus",
                TitleImage = "Octopus2.jpg",
                Description = "A large flat octopus that can turn and change color.",
                Price = 8.80M,
                CategoryId = 3
            };
            items.Add(item);

            item = new Item()
            {
                Id = 8,
                Title = "Sleeper",
                TitleImage = "Sleeper.jpg",
                Description = "A yellow plush slipper with blue stripes and a snap button so your dog can have his own look and leave yours alone.",
                Price = 9.50M,
                CategoryId = 3
            };
            items.Add(item);

            item = new Item()
            {
                Id = 9,
                Title = "Toilet Pads",
                TitleImage = "HygienicPad.jpg",
                Description = "Sanitary napkins with patches.",
                Price = 16.90M,
                CategoryId = 6
            };
            items.Add(item);

            item = new Item()
            {
                Id = 10,
                Title = "Comb for Long Fur",
                TitleImage = "LongGroomingSide.jpg",
                Description = "Double-sided comb for combing your pet with thicker fur.",
                Price = 14.50M,
                CategoryId = 7
            };
            items.Add(item);

            item = new Item()
            {
                Id = 11,
                Title = "Comb for Short Fur",
                TitleImage = "ShortGrooming.jpg",
                Description = "A comb specially designed for pets with short fur. Ideal for the shedding period.",
                Price = 34.15M,
                CategoryId = 7
            };
            items.Add(item);

            item = new Item()
            {
                Id = 12,
                Title = "SleepingPad - WonderWoman",
                TitleImage = "SleepingPad.jpg",
                Description = "Comfortable mattress, in a large size, easy to move. Extremely practical when traveling with your pet, as it does not take up much space. There is a zipper that can be used to remove the extra fabric from the inside and change it or wash it.",
                Price = 55.00M,
                CategoryId = 5
            };
            items.Add(item);

            item = new Item()
            {
                Id = 13,
                Title = "Bag - England Land",
                TitleImage = "TravelingBag2.jpg",
                Description = "Soft and comfortable bag with handles for carrying your pet, with a zipper for easier placement of the animal in it. Suitable for smaller breeds up to 4kg.",
                Price = 32.90M,
                CategoryId = 4
            };
            items.Add(item);

            item = new Item()
            {
                Id = 14,
                Title = "Cage - Pink sweetness",
                TitleImage = "TravelingCageTop.jpg",
                Description = "Pink plastic cage, suitable for pets up to 6 kg.",
                Price = 20.90M,
                CategoryId = 4
            };
            items.Add(item);

            item = new Item()
            {
                Id = 15,
                Title = "Water Bowl",
                TitleImage = "WaterBowl.jpg",
                Description = "Ceramic water bowl 300ml",
                Price = 8.50M,
                CategoryId = 8
            };
            items.Add(item);

            item = new Item()
            {
                Id = 16,
                Title = "Food Bowl",
                TitleImage = "FoodBowlTop.jpg",
                Description = "Ceramic food bowl 250ml",
                Price = 7.50M,
                CategoryId = 8
            };
            items.Add(item);

            item = new Item()
            {
                Id = 17,
                Title = "Breastplate - Casual Lines",
                TitleImage = "MeagerBreastplate2.jpg",
                Description = "Adjustable chest for small breeds up to 4kg, suitable for warmer summer days.",
                Price = 19.90M,
                CategoryId = 2
            };
            items.Add(item);

            item = new Item()
            {
                Id = 18,
                Title = "Breastplate - Pink madness",
                TitleImage = "BreastplateTop2.jpg",
                Description = "Thick, padded pink bib for small breeds up to 3kg, suitable for colder and cooler days.",
                Price = 14.30M,
                CategoryId = 2
            };
            items.Add(item);

            item = new Item()
            {
                Id = 19,
                Title = "Collar - Bell Kitty",
                TitleImage = "Collar2.jpg",
                Description = "Brown leather collar with attached bell designed for smaller breeds.",
                Price = 5.90M,
                CategoryId = 2
            };
            items.Add(item);

            item = new Item()
            {
                Id = 20,
                Title = "Ball - Rope",
                TitleImage = "BallSara2.jpg",
                Description = "Knitted ball with ropes on both sides.",
                Price = 12.00M,
                CategoryId = 3
            };
            items.Add(item);

            return items.ToArray();

        }
    }
}