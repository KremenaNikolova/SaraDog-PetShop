using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class InitializeAndSeedDB : Migration
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
                    { 1, "DressCategory.jpg", "Дрехи" },
                    { 2, "CollarCategory.jpg", "Нашийници, Нагръдници и Поводи" },
                    { 3, "ToyCategory.jpg", "Играчки" },
                    { 4, "TravellingCategory.jpg", "Транспортни клетки" },
                    { 5, "SleepingPad.jpg", "Легла" },
                    { 6, "HygienicPad.jpg", "Пелени и подложки" },
                    { 7, "ShortGroomingCloserCategory.jpg", "Грижа за козината" },
                    { 8, "DressCategory.jpg", "Купички за храна и вода" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AddedOn", "CategoryId", "Description", "Price", "Rating", "Title", "TitleImage" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4122), 1, "Жълто худи с мотиви на минион, в размер М, подходящо по-студените зимни дни.", 25.50m, null, "Худи- Минион", "MinionDress.jpg" },
                    { 2, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4136), 1, "Зелено худи с мотиви на мече и ушички на качулката, в размер М, подходящо по-студените зимни дни.", 35.90m, null, "Худи - Зелено мече", "GreenHoodie2.jpg" },
                    { 3, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4137), 1, "Дебела синя блузка с мотиви на мечета и розови листа, в размер М.", 20.30m, null, "Блуза - Синя есен", "BlueDress3.jpg" },
                    { 4, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4140), 1, "Лилаво изчистено худи с джобче, в размер М.", 19.90m, null, "Худи - Люлак", "PurpleHoodie.jpg" },
                    { 5, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4143), 1, "Дебела розова блузка, наподобяваща сладка пижамка, в размер М, подходяща по-студените зимни дни.", 20.30m, null, "Блуза - Розова пижама", "PinkDress2.jpg" },
                    { 6, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4144), 3, "Плюшено сладоледче, с бибитка при натискане и въженце на върха.", 10.10m, null, "Сладолед", "IceCream.jpg" },
                    { 7, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4145), 3, "Голем плючещен октопод, който може да се обръща и променя цвета си.", 8.80m, null, "Октопод", "Octopus2.jpg" },
                    { 8, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4147), 3, "Жълт плюшен черхъл, на сини райета, с бибитка при натискане, за да може кучето вида си има свой собствен и да остави вашите на мира.", 9.50m, null, "Чехъл", "Sleeper.jpg" },
                    { 9, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4149), 6, "Хигиенни подложки с лепенки.", 16.90m, null, "Хигиенни подложки", "HygienicPad.jpg" },
                    { 10, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4151), 7, "Двустранен гребен за сресване на вашият любимец с по-буйна козина.", 14.50m, null, "Гребен за дълга козина", "LongGroomingSide.jpg" },
                    { 11, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4152), 7, "Гребен специално предназначен за домашни любимци, които са със къса козина. Идеален за периода на смяна на козината.", 34.15m, null, "Гребен за къса козина", "ShortGrooming.jpg" },
                    { 12, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4153), 5, "Удобен матрак, в голям размер, удобен за местене. Изключително практичен при пътуване с вашият любимец, тъй като не заема много място. Има цип, с който може да се вади донапрена отвътре и да се сменя или пере.", 55.00m, null, "Матрак - WonderWoman", "SleepingPad.jpg" },
                    { 13, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4154), 4, "Мека и удобна чанта с дръжки за пренасяне на вашият любимец, с ципче за по-лесно поставяне на животното в нея. Подходяща за по-дребни породи до 4кг.", 32.90m, null, "Чанта - England Land", "TravelingBag2.jpg" },
                    { 14, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4155), 4, "Розова пластмасова клетка, подходяща за домашни любимци до 6кг.", 20.90m, null, "Клетка - Розова сладост", "TravelingCageTop.jpg" },
                    { 15, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4156), 8, "Керамична купичка за вода 300мл", 8.50m, null, "Купа за вода", "WaterBowl.jpg" },
                    { 16, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4157), 8, "Керамична купичка за храна 250мл", 7.50m, null, "Купа за храна", "FoodBowlTop.jpg" },
                    { 17, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4159), 2, "Регулируем нагръдник за дребни породи до 4кг, подходящ за по-топлите летни дни.", 19.90m, null, "Нагръдник - Лентички", "MeagerBreastplate2.jpg" },
                    { 18, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4160), 2, "Дебел, подплатен розов нагръдник за дребни породи до 3кг, подходящ за по-студените и прохладни дни.", 14.30m, null, "Нагръдник - Розова лудост", "BreastplateTop2.jpg" },
                    { 19, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4163), 2, "Кафяв, кожеш нашийник с прикачено звънче, предназначен за по-дребни породи.", 5.90m, null, "Нашийник - Звънкащо котенце", "Collar2.jpg" },
                    { 20, new DateTime(2023, 7, 11, 15, 24, 35, 190, DateTimeKind.Utc).AddTicks(4164), 3, "Плетена топка с въженца от двете страни", 12.00m, null, "Топка-Въже", "BallSara2.jpg" }
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
