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

            string imagesFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images");

            Item item;

            item = new Item()
            {
                Id = 1,
                Title = "Худи- Минион",
                TitleImage = Path.Combine(imagesFolderPath, "MinionDress.jpg"),
                Description = "Жълто худи с мотиви на минион, в размер М, подходящо по-студените зимни дни.",
                Price = 25.50M,
                CategoryId = 1,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 2,
                Title = "Худи - Зелено мече",
                TitleImage = Path.Combine(imagesFolderPath, "GreenHoodie2.jpg"),
                Description = "Зелено худи с мотиви на мече и ушички на качулката, в размер М, подходящо по-студените зимни дни.",
                Price = 35.90M,
                CategoryId = 1,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 3,
                Title = "Блуза - Синя есен",
                TitleImage = Path.Combine(imagesFolderPath, "BlueDress3.jpg"),
                Description = "Дебела синя блузка с мотиви на мечета и розови листа, в размер М.",
                Price = 20.30M,
                CategoryId = 1,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 4,
                Title = "Худи - Люлак",
                TitleImage = Path.Combine(imagesFolderPath, "PurpleHoodie.jpg"),
                Description = "Лилаво изчистено худи с джобче, в размер М.",
                Price = 19.90M,
                CategoryId = 1,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 5,
                Title = "Блуза - Розова пижама",
                TitleImage = Path.Combine(imagesFolderPath, "PinkDress2.jpg"),
                Description = "Дебела розова блузка, наподобяваща сладка пижамка, в размер М, подходяща по-студените зимни дни.",
                Price = 20.30M,
                CategoryId = 1,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 6,
                Title = "Сладолед",
                TitleImage = Path.Combine(imagesFolderPath, "IceCream.jpg"),
                Description = "Плюшено сладоледче, с бибитка при натискане и въженце на върха.",
                Price = 10.10M,
                CategoryId = 3,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 7,
                Title = "Октопод",
                TitleImage = Path.Combine(imagesFolderPath, "Octopus2.jpg"),
                Description = "Голем плючещен октопод, който може да се обръща и променя цвета си.",
                Price = 8.80M,
                CategoryId = 3,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 8,
                Title = "Чехъл",
                TitleImage = Path.Combine(imagesFolderPath, "Sleeper.jpg"),
                Description = "Жълт плюшен черхъл, на сини райета, с бибитка при натискане, за да може кучето вида си има свой собствен и да остави вашите на мира.",
                Price = 9.50M,
                CategoryId = 3,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 9,
                Title = "Хигиенни подложки",
                TitleImage = Path.Combine(imagesFolderPath, "HygienicPad.jpg"),
                Description = "Хигиенни подложки с лепенки.",
                Price = 16.90M,
                CategoryId = 6,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 10,
                Title = "Гребен за дълга козина",
                TitleImage = Path.Combine(imagesFolderPath, "LongGroomingSide.jpg"),
                Description = "Двустранен гребен за сресване на вашият любимец с по-буйна козина.",
                Price = 14.50M,
                CategoryId = 7,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 11,
                Title = "Гребен за къса козина",
                TitleImage = Path.Combine(imagesFolderPath, "ShortGrooming.jpg"),
                Description = "Гребен специално предназначен за домашни любимци, които са със къса козина. Идеален за периода на смяна на козината.",
                Price = 34.15M,
                CategoryId = 7,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 12,
                Title = "Матрак - WonderWoman",
                TitleImage = Path.Combine(imagesFolderPath, "SleepingPad.jpg"),
                Description = "Удобен матрак, в голям размер, удобен за местене. Изключително практичен при пътуване с вашият любимец, тъй като не заема много място. Има цип, с който може да се вади донапрена отвътре и да се сменя или пере.",
                Price = 55.00M,
                CategoryId = 5,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 13,
                Title = "Чанта - England Land",
                TitleImage = Path.Combine(imagesFolderPath, "TravelingBag2.jpg"),
                Description = "Мека и удобна чанта с дръжки за пренасяне на вашият любимец, с ципче за по-лесно поставяне на животното в нея. Подходяща за по-дребни породи до 4кг.",
                Price = 32.90M,
                CategoryId = 4,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 14,
                Title = "Клетка - Розова сладост",
                TitleImage = Path.Combine(imagesFolderPath, "TravelingCageTop.jpg"),
                Description = "Розова пластмасова клетка, подходяща за домашни любимци до 6кг.",
                Price = 20.90M,
                CategoryId = 4,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 15,
                Title = "Купа за вода",
                TitleImage = Path.Combine(imagesFolderPath, "WaterBowl.jpg"),
                Description = "Керамична купичка за вода 300мл",
                Price = 8.50M,
                CategoryId = 8,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 16,
                Title = "Купа за храна",
                TitleImage = Path.Combine(imagesFolderPath, "FoodBowlTop.jpg"),
                Description = "Керамична купичка за храна 250мл",
                Price = 7.50M,
                CategoryId = 8,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 17,
                Title = "Нагръдник - Лентички",
                TitleImage = Path.Combine(imagesFolderPath, "МеагерBreastplate2.jpg"),
                Description = "Регулируем нагръдник за дребни породи до 4кг, подходящ за по-топлите летни дни.",
                Price = 19.90M,
                CategoryId = 2,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 18,
                Title = "Нагръдник - Розова лудост",
                TitleImage = Path.Combine(imagesFolderPath, "BreastplateTop2.jpg"),
                Description = "Дебел, подплатен розов нагръдник за дребни породи до 3кг, подходящ за по-студените и прохладни дни.",
                Price = 14.30M,
                CategoryId = 2,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 19,
                Title = "Нашийник - Звънкащо котенце",
                TitleImage = Path.Combine(imagesFolderPath, "Collar2.jpg"),
                Description = "Кафяв, кожеш нашийник с прикачено звънче, предназначен за по-дребни породи.",
                Price = 5.90M,
                CategoryId = 2,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            item = new Item()
            {
                Id = 20,
                Title = "Топка-Въже",
                TitleImage = Path.Combine(imagesFolderPath, "BallSara2.jpg"),
                Description = "Плетена топка с въженца от двете страни",
                Price = 12.00M,
                CategoryId = 3,
                IsDeleted = false,
                IsVisible = true
            };
            items.Add(item);

            return items.ToArray();

        }
    }
}