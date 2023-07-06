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

                    b.Property<bool?>("IsDeleted")
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
                            IsDeleted = false,
                            Name = "Дрехи"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Нашийници, Нагръдници и Поводи"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Играчки"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Транспортни клетки"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Легла"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Пелени и подложки"
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "Грижа за козината"
                        },
                        new
                        {
                            Id = 8,
                            IsDeleted = false,
                            Name = "Купички за храна и вода"
                        });
                });

            modelBuilder.Entity("PetShop.Data.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Images");
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

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsVisible")
                        .HasColumnType("bit");

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
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8833),
                            CategoryId = 1,
                            Description = "Жълто худи с мотиви на минион, в размер М, подходящо по-студените зимни дни.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 25.50m,
                            Title = "Худи- Минион",
                            TitleImage = "~/Images/Ball.jpg"
                        },
                        new
                        {
                            Id = 2,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8844),
                            CategoryId = 1,
                            Description = "Зелено худи с мотиви на мече и ушички на качулката, в размер М, подходящо по-студените зимни дни.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 35.90m,
                            Title = "Худи - Зелено мече",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\GreenHoodie2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8848),
                            CategoryId = 1,
                            Description = "Дебела синя блузка с мотиви на мечета и розови листа, в размер М.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 20.30m,
                            Title = "Блуза - Синя есен",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\BlueDress3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8851),
                            CategoryId = 1,
                            Description = "Лилаво изчистено худи с джобче, в размер М.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 19.90m,
                            Title = "Худи - Люлак",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\PurpleHoodie.jpg"
                        },
                        new
                        {
                            Id = 5,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8856),
                            CategoryId = 1,
                            Description = "Дебела розова блузка, наподобяваща сладка пижамка, в размер М, подходяща по-студените зимни дни.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 20.30m,
                            Title = "Блуза - Розова пижама",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\PinkDress2.jpg"
                        },
                        new
                        {
                            Id = 6,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8859),
                            CategoryId = 3,
                            Description = "Плюшено сладоледче, с бибитка при натискане и въженце на върха.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 10.10m,
                            Title = "Сладолед",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\IceCream.jpg"
                        },
                        new
                        {
                            Id = 7,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8862),
                            CategoryId = 3,
                            Description = "Голем плючещен октопод, който може да се обръща и променя цвета си.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 8.80m,
                            Title = "Октопод",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\Octopus2.jpg"
                        },
                        new
                        {
                            Id = 8,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8863),
                            CategoryId = 3,
                            Description = "Жълт плюшен черхъл, на сини райета, с бибитка при натискане, за да може кучето вида си има свой собствен и да остави вашите на мира.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 9.50m,
                            Title = "Чехъл",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\Sleeper.jpg"
                        },
                        new
                        {
                            Id = 9,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8867),
                            CategoryId = 6,
                            Description = "Хигиенни подложки с лепенки.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 16.90m,
                            Title = "Хигиенни подложки",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\HygienicPad.jpg"
                        },
                        new
                        {
                            Id = 10,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8870),
                            CategoryId = 7,
                            Description = "Двустранен гребен за сресване на вашият любимец с по-буйна козина.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 14.50m,
                            Title = "Гребен за дълга козина",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\LongGroomingSide.jpg"
                        },
                        new
                        {
                            Id = 11,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8873),
                            CategoryId = 7,
                            Description = "Гребен специално предназначен за домашни любимци, които са със къса козина. Идеален за периода на смяна на козината.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 34.15m,
                            Title = "Гребен за къса козина",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\ShortGrooming.jpg"
                        },
                        new
                        {
                            Id = 12,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8875),
                            CategoryId = 5,
                            Description = "Удобен матрак, в голям размер, удобен за местене. Изключително практичен при пътуване с вашият любимец, тъй като не заема много място. Има цип, с който може да се вади донапрена отвътре и да се сменя или пере.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 55.00m,
                            Title = "Матрак - WonderWoman",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\SleepingPad.jpg"
                        },
                        new
                        {
                            Id = 13,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8878),
                            CategoryId = 4,
                            Description = "Мека и удобна чанта с дръжки за пренасяне на вашият любимец, с ципче за по-лесно поставяне на животното в нея. Подходяща за по-дребни породи до 4кг.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 32.90m,
                            Title = "Чанта - England Land",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\TravelingBag2.jpg"
                        },
                        new
                        {
                            Id = 14,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8880),
                            CategoryId = 4,
                            Description = "Розова пластмасова клетка, подходяща за домашни любимци до 6кг.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 20.90m,
                            Title = "Клетка - Розова сладост",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\TravelingCageTop.jpg"
                        },
                        new
                        {
                            Id = 15,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8908),
                            CategoryId = 8,
                            Description = "Керамична купичка за вода 300мл",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 8.50m,
                            Title = "Купа за вода",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\WaterBowl.jpg"
                        },
                        new
                        {
                            Id = 16,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8911),
                            CategoryId = 8,
                            Description = "Керамична купичка за храна 250мл",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 7.50m,
                            Title = "Купа за храна",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\FoodBowlTop.jpg"
                        },
                        new
                        {
                            Id = 17,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8913),
                            CategoryId = 2,
                            Description = "Регулируем нагръдник за дребни породи до 4кг, подходящ за по-топлите летни дни.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 19.90m,
                            Title = "Нагръдник - Лентички",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\МеагерBreastplate2.jpg"
                        },
                        new
                        {
                            Id = 18,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8916),
                            CategoryId = 2,
                            Description = "Дебел, подплатен розов нагръдник за дребни породи до 3кг, подходящ за по-студените и прохладни дни.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 14.30m,
                            Title = "Нагръдник - Розова лудост",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\BreastplateTop2.jpg"
                        },
                        new
                        {
                            Id = 19,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8919),
                            CategoryId = 2,
                            Description = "Кафяв, кожеш нашийник с прикачено звънче, предназначен за по-дребни породи.",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 5.90m,
                            Title = "Нашийник - Звънкащо котенце",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\Collar2.jpg"
                        },
                        new
                        {
                            Id = 20,
                            AddedOn = new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8921),
                            CategoryId = 3,
                            Description = "Плетена топка с въженца от двете страни",
                            IsDeleted = false,
                            IsVisible = true,
                            Price = 12.00m,
                            Title = "Топка-Въже",
                            TitleImage = "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\BallSara2.jpg"
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

            modelBuilder.Entity("PetShop.Data.Models.Image", b =>
                {
                    b.HasOne("PetShop.Data.Models.Item", null)
                        .WithMany("Images")
                        .HasForeignKey("ItemId");
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
                    b.Navigation("Images");

                    b.Navigation("UserItems");
                });
#pragma warning restore 612, 618
        }
    }
}
