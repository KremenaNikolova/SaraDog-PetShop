using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class InitializeAndSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TitleImage = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserItems",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItems", x => new { x.UserId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_UserItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "DressCategory.jpg", "Clothing" },
                    { 2, "CollarCategory.jpg", "Leads and Collars" },
                    { 3, "ToyCategory.jpg", "Toys" },
                    { 4, "TravellingCategory.jpg", "Travelling Crates and Bags" },
                    { 5, "SleepingPad.jpg", "Beds and Sleeping" },
                    { 6, "HygienicPad.jpg", "Hygienic Pads" },
                    { 7, "ShortGroomingCloserCategory.jpg", "Grooming" },
                    { 8, "DressCategory.jpg", "Food and Water Bowls" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AddedOn", "CategoryId", "Description", "Price", "Rating", "Title", "TitleImage" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8206), 1, "Yellow hoodie with minion motifs, size M, suitable for colder winter days.", 25.50m, null, "Hoodie - Minions", "MinionDress.jpg" },
                    { 2, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8215), 1, "Green hoodie with bear motifs and eyelets on the hood, size M, suitable for colder winter days.", 35.90m, null, "Hoodie - Green bear", "GreenHoodie2.jpg" },
                    { 3, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8217), 1, "Thick blue blouse with bears and rose leaf motifs, size M.", 20.30m, null, "Top - Blue autumn", "BlueDress3.jpg" },
                    { 4, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8218), 1, "Purple clean hoodie with pocket, size M.", 19.90m, null, "Hoodie - Lilac", "PurpleHoodie.jpg" },
                    { 5, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8222), 1, "A thick pink blouse that looks like a cute pajama, size M, perfect for colder winter days.", 20.30m, null, "Top - Pink pajamas", "PinkDress2.jpg" },
                    { 6, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8223), 3, "Plush ice cream, with a push button and a rope on the top.", 10.10m, null, "Ice cream", "IceCream.jpg" },
                    { 7, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8224), 3, "A large flat octopus that can turn and change color.", 8.80m, null, "Octopus", "Octopus2.jpg" },
                    { 8, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8225), 3, "A yellow plush slipper with blue stripes and a snap button so your dog can have his own look and leave yours alone.", 9.50m, null, "Sleeper", "Sleeper.jpg" },
                    { 9, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8228), 6, "Sanitary napkins with patches.", 16.90m, null, "Toilet Pads", "HygienicPad.jpg" },
                    { 10, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8229), 7, "Double-sided comb for combing your pet with thicker fur.", 14.50m, null, "Comb for Long Fur", "LongGroomingSide.jpg" },
                    { 11, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8230), 7, "A comb specially designed for pets with short fur. Ideal for the shedding period.", 34.15m, null, "Comb for Short Fur", "ShortGrooming.jpg" },
                    { 12, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8231), 5, "Comfortable mattress, in a large size, easy to move. Extremely practical when traveling with your pet, as it does not take up much space. There is a zipper that can be used to remove the extra fabric from the inside and change it or wash it.", 55.00m, null, "SleepingPad - WonderWoman", "SleepingPad.jpg" },
                    { 13, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8233), 4, "Soft and comfortable bag with handles for carrying your pet, with a zipper for easier placement of the animal in it. Suitable for smaller breeds up to 4kg.", 32.90m, null, "Bag - England Land", "TravelingBag2.jpg" },
                    { 14, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8234), 4, "Pink plastic cage, suitable for pets up to 6 kg.", 20.90m, null, "Cage - Pink sweetness", "TravelingCageTop.jpg" },
                    { 15, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8235), 8, "Ceramic water bowl 300ml", 8.50m, null, "Water Bowl", "WaterBowl.jpg" },
                    { 16, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8236), 8, "Ceramic food bowl 250ml", 7.50m, null, "Food Bowl", "FoodBowlTop.jpg" },
                    { 17, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8238), 2, "Adjustable chest for small breeds up to 4kg, suitable for warmer summer days.", 19.90m, null, "Breastplate - Casual Lines", "MeagerBreastplate2.jpg" },
                    { 18, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8239), 2, "Thick, padded pink bib for small breeds up to 3kg, suitable for colder and cooler days.", 14.30m, null, "Breastplate - Pink madness", "BreastplateTop2.jpg" },
                    { 19, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8241), 2, "Brown leather collar with attached bell designed for smaller breeds.", 5.90m, null, "Collar - Bell Kitty", "Collar2.jpg" },
                    { 20, new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8242), 3, "Knitted ball with ropes on both sides.", 12.00m, null, "Ball - Rope", "BallSara2.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_ItemId",
                table: "UserItems",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UserItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
