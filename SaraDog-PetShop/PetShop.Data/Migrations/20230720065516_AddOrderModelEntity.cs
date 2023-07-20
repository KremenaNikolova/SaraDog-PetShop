using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddOrderModelEntity : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1057), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1108), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1121), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1124), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1137), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1140), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1143), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1147), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1150), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1183), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1188), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1191), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1195), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1198), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1203), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1206), new DateTime(2023, 7, 20, 9, 55, 15, 854, DateTimeKind.Local).AddTicks(1207) });

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
