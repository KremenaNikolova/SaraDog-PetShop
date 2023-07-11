﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.Web.Data;

#nullable disable

namespace PetShop.Data.Migrations
{
    [DbContext(typeof(PetShopDbContext))]
    [Migration("20230711152435_InitializeAndSeedDB")]
    partial class InitializeAndSeedDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
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
                            Name = "Дрехи"
                        },
                        new
                        {
                            Id = 2,
                            Image = "CollarCategory.jpg",
                            Name = "Нашийници, Нагръдници и Поводи"
                        },
                        new
                        {
                            Id = 3,
                            Image = "ToyCategory.jpg",
                            Name = "Играчки"
                        },
                        new
                        {
                            Id = 4,
                            Image = "TravellingCategory.jpg",
                            Name = "Транспортни клетки"
                        },
                        new
                        {
                            Id = 5,
                            Image = "SleepingPad.jpg",
                            Name = "Легла"
                        },
                        new
                        {
                            Id = 6,
                            Image = "HygienicPad.jpg",
                            Name = "Пелени и подложки"
                        },
                        new
                        {
                            Id = 7,
                            Image = "ShortGroomingCloserCategory.jpg",
                            Name = "Грижа за козината"
                        },
                        new
                        {
                            Id = 8,
                            Image = "DressCategory.jpg",
                            Name = "Купички за храна и вода"
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
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

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
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4122),
                            CategoryId = 1,
                            Description = "Жълто худи с мотиви на минион, в размер М, подходящо по-студените зимни дни.",
                            Price = 25.50m,
                            Title = "Худи- Минион",
                            TitleImage = "MinionDress.jpg"
                        },
                        new
                        {
                            Id = 2,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4136),
                            CategoryId = 1,
                            Description = "Зелено худи с мотиви на мече и ушички на качулката, в размер М, подходящо по-студените зимни дни.",
                            Price = 35.90m,
                            Title = "Худи - Зелено мече",
                            TitleImage = "GreenHoodie2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4137),
                            CategoryId = 1,
                            Description = "Дебела синя блузка с мотиви на мечета и розови листа, в размер М.",
                            Price = 20.30m,
                            Title = "Блуза - Синя есен",
                            TitleImage = "BlueDress3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4140),
                            CategoryId = 1,
                            Description = "Лилаво изчистено худи с джобче, в размер М.",
                            Price = 19.90m,
                            Title = "Худи - Люлак",
                            TitleImage = "PurpleHoodie.jpg"
                        },
                        new
                        {
                            Id = 5,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4143),
                            CategoryId = 1,
                            Description = "Дебела розова блузка, наподобяваща сладка пижамка, в размер М, подходяща по-студените зимни дни.",
                            Price = 20.30m,
                            Title = "Блуза - Розова пижама",
                            TitleImage = "PinkDress2.jpg"
                        },
                        new
                        {
                            Id = 6,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4144),
                            CategoryId = 3,
                            Description = "Плюшено сладоледче, с бибитка при натискане и въженце на върха.",
                            Price = 10.10m,
                            Title = "Сладолед",
                            TitleImage = "IceCream.jpg"
                        },
                        new
                        {
                            Id = 7,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4145),
                            CategoryId = 3,
                            Description = "Голем плючещен октопод, който може да се обръща и променя цвета си.",
                            Price = 8.80m,
                            Title = "Октопод",
                            TitleImage = "Octopus2.jpg"
                        },
                        new
                        {
                            Id = 8,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4147),
                            CategoryId = 3,
                            Description = "Жълт плюшен черхъл, на сини райета, с бибитка при натискане, за да може кучето вида си има свой собствен и да остави вашите на мира.",
                            Price = 9.50m,
                            Title = "Чехъл",
                            TitleImage = "Sleeper.jpg"
                        },
                        new
                        {
                            Id = 9,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4149),
                            CategoryId = 6,
                            Description = "Хигиенни подложки с лепенки.",
                            Price = 16.90m,
                            Title = "Хигиенни подложки",
                            TitleImage = "HygienicPad.jpg"
                        },
                        new
                        {
                            Id = 10,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4151),
                            CategoryId = 7,
                            Description = "Двустранен гребен за сресване на вашият любимец с по-буйна козина.",
                            Price = 14.50m,
                            Title = "Гребен за дълга козина",
                            TitleImage = "LongGroomingSide.jpg"
                        },
                        new
                        {
                            Id = 11,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4152),
                            CategoryId = 7,
                            Description = "Гребен специално предназначен за домашни любимци, които са със къса козина. Идеален за периода на смяна на козината.",
                            Price = 34.15m,
                            Title = "Гребен за къса козина",
                            TitleImage = "ShortGrooming.jpg"
                        },
                        new
                        {
                            Id = 12,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4153),
                            CategoryId = 5,
                            Description = "Удобен матрак, в голям размер, удобен за местене. Изключително практичен при пътуване с вашият любимец, тъй като не заема много място. Има цип, с който може да се вади донапрена отвътре и да се сменя или пере.",
                            Price = 55.00m,
                            Title = "Матрак - WonderWoman",
                            TitleImage = "SleepingPad.jpg"
                        },
                        new
                        {
                            Id = 13,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4154),
                            CategoryId = 4,
                            Description = "Мека и удобна чанта с дръжки за пренасяне на вашият любимец, с ципче за по-лесно поставяне на животното в нея. Подходяща за по-дребни породи до 4кг.",
                            Price = 32.90m,
                            Title = "Чанта - England Land",
                            TitleImage = "TravelingBag2.jpg"
                        },
                        new
                        {
                            Id = 14,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4155),
                            CategoryId = 4,
                            Description = "Розова пластмасова клетка, подходяща за домашни любимци до 6кг.",
                            Price = 20.90m,
                            Title = "Клетка - Розова сладост",
                            TitleImage = "TravelingCageTop.jpg"
                        },
                        new
                        {
                            Id = 15,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4156),
                            CategoryId = 8,
                            Description = "Керамична купичка за вода 300мл",
                            Price = 8.50m,
                            Title = "Купа за вода",
                            TitleImage = "WaterBowl.jpg"
                        },
                        new
                        {
                            Id = 16,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4157),
                            CategoryId = 8,
                            Description = "Керамична купичка за храна 250мл",
                            Price = 7.50m,
                            Title = "Купа за храна",
                            TitleImage = "FoodBowlTop.jpg"
                        },
                        new
                        {
                            Id = 17,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4159),
                            CategoryId = 2,
                            Description = "Регулируем нагръдник за дребни породи до 4кг, подходящ за по-топлите летни дни.",
                            Price = 19.90m,
                            Title = "Нагръдник - Лентички",
                            TitleImage = "MeagerBreastplate2.jpg"
                        },
                        new
                        {
                            Id = 18,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4160),
                            CategoryId = 2,
                            Description = "Дебел, подплатен розов нагръдник за дребни породи до 3кг, подходящ за по-студените и прохладни дни.",
                            Price = 14.30m,
                            Title = "Нагръдник - Розова лудост",
                            TitleImage = "BreastplateTop2.jpg"
                        },
                        new
                        {
                            Id = 19,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4163),
                            CategoryId = 2,
                            Description = "Кафяв, кожеш нашийник с прикачено звънче, предназначен за по-дребни породи.",
                            Price = 5.90m,
                            Title = "Нашийник - Звънкащо котенце",
                            TitleImage = "Collar2.jpg"
                        },
                        new
                        {
                            Id = 20,
                            AddedOn = new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4164),
                            CategoryId = 3,
                            Description = "Плетена топка с въженца от двете страни",
                            Price = 12.00m,
                            Title = "Топка-Въже",
                            TitleImage = "BallSara2.jpg"
                        });
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

            modelBuilder.Entity("PetShop.Data.Models.Item", b =>
                {
                    b.HasOne("PetShop.Data.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
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