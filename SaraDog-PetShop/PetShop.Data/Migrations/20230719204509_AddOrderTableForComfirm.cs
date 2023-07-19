using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddOrderTableForComfirm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5194), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5198), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5202), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5211), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5215), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5219), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5227), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5231), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5238), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5241), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5246), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5253), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5257), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5262), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5265), new DateTime(2023, 7, 19, 23, 45, 9, 669, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CartId",
                table: "Orders",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(202), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(250), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(258), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(264), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(296), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(300), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(303), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(308), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(312), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(327), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(331), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(334), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(342), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(348), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(351), new DateTime(2023, 7, 19, 11, 25, 11, 990, DateTimeKind.Local).AddTicks(352) });
        }
    }
}
