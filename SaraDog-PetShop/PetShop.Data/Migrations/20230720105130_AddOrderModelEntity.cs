using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddOrderModelEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9856), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9913), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9930), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9934), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9937), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9941), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9944), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9951), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9955), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9970), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9973), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9975) });

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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1500)",
                oldMaxLength: 1500);

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
