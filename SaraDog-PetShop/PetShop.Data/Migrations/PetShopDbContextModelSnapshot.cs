﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.Web.Data;

#nullable disable

namespace PetShop.Data.Migrations
{
    [DbContext(typeof(PetShopDbContext))]
    partial class PetShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PetShop.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsModerator")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("PetShop.Data.Models.ApplicationUserItem", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("UserItems");
                });

            modelBuilder.Entity("PetShop.Data.Models.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("PetShop.Data.Models.CartItem", b =>
                {
                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("PetShop.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "DressCategory.jpg",
                            IsDeleted = false,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 2,
                            Image = "CollarCategory.jpg",
                            IsDeleted = false,
                            Name = "Leads and Collars"
                        },
                        new
                        {
                            Id = 3,
                            Image = "ToyCategory.jpg",
                            IsDeleted = false,
                            Name = "Toys"
                        },
                        new
                        {
                            Id = 4,
                            Image = "TravellingCategory.jpg",
                            IsDeleted = false,
                            Name = "Travelling Crates and Bags"
                        },
                        new
                        {
                            Id = 5,
                            Image = "SleepingPad.jpg",
                            IsDeleted = false,
                            Name = "Beds and Sleeping"
                        },
                        new
                        {
                            Id = 6,
                            Image = "HygienicPad.jpg",
                            IsDeleted = false,
                            Name = "Hygienic Pads"
                        },
                        new
                        {
                            Id = 7,
                            Image = "ShortGroomingCloserCategory.jpg",
                            IsDeleted = false,
                            Name = "Grooming"
                        },
                        new
                        {
                            Id = 8,
                            Image = "DressCategory.jpg",
                            IsDeleted = false,
                            Name = "Food and Water Bowls"
                        });
                });

            modelBuilder.Entity("PetShop.Data.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastEdit")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Rating")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TitleImage")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6488),
                            CategoryId = 1,
                            Description = "Yellow hoodie with minion motifs, size M, suitable for colder winter days.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6528),
                            Price = 25.50m,
                            Title = "Hoodie - Minions",
                            TitleImage = "MinionDress.jpg"
                        },
                        new
                        {
                            Id = 2,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6541),
                            CategoryId = 1,
                            Description = "Green hoodie with bear motifs and eyelets on the hood, size M, suitable for colder winter days.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6543),
                            Price = 35.90m,
                            Title = "Hoodie - Green bear",
                            TitleImage = "GreenHoodie2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6546),
                            CategoryId = 1,
                            Description = "Thick blue blouse with bears and rose leaf motifs, size M.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6547),
                            Price = 20.30m,
                            Title = "Top - Blue autumn",
                            TitleImage = "BlueDress3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6549),
                            CategoryId = 1,
                            Description = "Purple clean hoodie with pocket, size M.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6551),
                            Price = 19.90m,
                            Title = "Hoodie - Lilac",
                            TitleImage = "PurpleHoodie.jpg"
                        },
                        new
                        {
                            Id = 5,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6555),
                            CategoryId = 1,
                            Description = "A thick pink blouse that looks like a cute pajama, size M, perfect for colder winter days.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6556),
                            Price = 20.30m,
                            Title = "Top - Pink pajamas",
                            TitleImage = "PinkDress2.jpg"
                        },
                        new
                        {
                            Id = 6,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6558),
                            CategoryId = 3,
                            Description = "Plush ice cream, with a push button and a rope on the top.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6560),
                            Price = 10.10m,
                            Title = "Ice cream",
                            TitleImage = "IceCream.jpg"
                        },
                        new
                        {
                            Id = 7,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6562),
                            CategoryId = 3,
                            Description = "A large flat octopus that can turn and change color.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6563),
                            Price = 8.80m,
                            Title = "Octopus",
                            TitleImage = "Octopus2.jpg"
                        },
                        new
                        {
                            Id = 8,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6565),
                            CategoryId = 3,
                            Description = "A yellow plush slipper with blue stripes and a snap button so your dog can have his own look and leave yours alone.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6566),
                            Price = 9.50m,
                            Title = "Sleeper",
                            TitleImage = "Sleeper.jpg"
                        },
                        new
                        {
                            Id = 9,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6570),
                            CategoryId = 6,
                            Description = "Sanitary napkins with patches.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6571),
                            Price = 16.90m,
                            Title = "Toilet Pads",
                            TitleImage = "HygienicPad.jpg"
                        },
                        new
                        {
                            Id = 10,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6573),
                            CategoryId = 7,
                            Description = "Double-sided comb for combing your pet with thicker fur.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6575),
                            Price = 14.50m,
                            Title = "Comb for Long Fur",
                            TitleImage = "LongGroomingSide.jpg"
                        },
                        new
                        {
                            Id = 11,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6577),
                            CategoryId = 7,
                            Description = "A comb specially designed for pets with short fur. Ideal for the shedding period.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6578),
                            Price = 34.15m,
                            Title = "Comb for Short Fur",
                            TitleImage = "ShortGrooming.jpg"
                        },
                        new
                        {
                            Id = 12,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6580),
                            CategoryId = 5,
                            Description = "Comfortable mattress, in a large size, easy to move. Extremely practical when traveling with your pet, as it does not take up much space. There is a zipper that can be used to remove the extra fabric from the inside and change it or wash it.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6582),
                            Price = 55.00m,
                            Title = "SleepingPad - WonderWoman",
                            TitleImage = "SleepingPad.jpg"
                        },
                        new
                        {
                            Id = 13,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6584),
                            CategoryId = 4,
                            Description = "Soft and comfortable bag with handles for carrying your pet, with a zipper for easier placement of the animal in it. Suitable for smaller breeds up to 4kg.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6585),
                            Price = 32.90m,
                            Title = "Bag - England Land",
                            TitleImage = "TravelingBag2.jpg"
                        },
                        new
                        {
                            Id = 14,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6587),
                            CategoryId = 4,
                            Description = "Pink plastic cage, suitable for pets up to 6 kg.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6588),
                            Price = 20.90m,
                            Title = "Cage - Pink sweetness",
                            TitleImage = "TravelingCageTop.jpg"
                        },
                        new
                        {
                            Id = 15,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6592),
                            CategoryId = 8,
                            Description = "Ceramic water bowl 300ml",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6593),
                            Price = 8.50m,
                            Title = "Water Bowl",
                            TitleImage = "WaterBowl.jpg"
                        },
                        new
                        {
                            Id = 16,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6595),
                            CategoryId = 8,
                            Description = "Ceramic food bowl 250ml",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6596),
                            Price = 7.50m,
                            Title = "Food Bowl",
                            TitleImage = "FoodBowlTop.jpg"
                        },
                        new
                        {
                            Id = 17,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6598),
                            CategoryId = 2,
                            Description = "Adjustable chest for small breeds up to 4kg, suitable for warmer summer days.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6600),
                            Price = 19.90m,
                            Title = "Breastplate - Casual Lines",
                            TitleImage = "MeagerBreastplate2.jpg"
                        },
                        new
                        {
                            Id = 18,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6602),
                            CategoryId = 2,
                            Description = "Thick, padded pink bib for small breeds up to 3kg, suitable for colder and cooler days.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6603),
                            Price = 14.30m,
                            Title = "Breastplate - Pink madness",
                            TitleImage = "BreastplateTop2.jpg"
                        },
                        new
                        {
                            Id = 19,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6636),
                            CategoryId = 2,
                            Description = "Brown leather collar with attached bell designed for smaller breeds.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6637),
                            Price = 5.90m,
                            Title = "Collar - Bell Kitty",
                            TitleImage = "Collar2.jpg"
                        },
                        new
                        {
                            Id = 20,
                            AddedOn = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6640),
                            CategoryId = 3,
                            Description = "Knitted ball with ropes on both sides.",
                            IsActive = true,
                            IsDeleted = false,
                            LastEdit = new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6641),
                            Price = 12.00m,
                            Title = "Ball - Rope",
                            TitleImage = "BallSara2.jpg"
                        });
                });

            modelBuilder.Entity("PetShop.Data.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("PetShop.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("PetShop.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShop.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("PetShop.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetShop.Data.Models.ApplicationUserItem", b =>
                {
                    b.HasOne("PetShop.Data.Models.Item", "Item")
                        .WithMany("UserItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShop.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetShop.Data.Models.Cart", b =>
                {
                    b.HasOne("PetShop.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetShop.Data.Models.CartItem", b =>
                {
                    b.HasOne("PetShop.Data.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PetShop.Data.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("PetShop.Data.Models.Item", b =>
                {
                    b.HasOne("PetShop.Data.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PetShop.Data.Models.Order", b =>
                {
                    b.HasOne("PetShop.Data.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShop.Data.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetShop.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PetShop.Data.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("PetShop.Data.Models.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("PetShop.Data.Models.Item", b =>
                {
                    b.Navigation("UserItems");
                });
#pragma warning restore 612, 618
        }
    }
}
