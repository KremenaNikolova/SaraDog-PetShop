using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddCartEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.CartId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6605), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6664), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6669), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6673), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6676), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6679), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6684), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6687), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6691), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6697), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6701), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6705), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6708), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(7188), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(7203), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(7208), new DateTime(2023, 7, 18, 20, 55, 5, 615, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ItemId",
                table: "CartItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4301), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4305), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4310), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4315), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4319), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4322), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4325), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4331), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4334), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4338), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4342), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4348), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4351), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4355), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4358), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4361), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4366), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4369), new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4370) });
        }
    }
}
