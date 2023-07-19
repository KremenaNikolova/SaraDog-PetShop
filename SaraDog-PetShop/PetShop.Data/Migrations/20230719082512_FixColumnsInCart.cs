using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class FixColumnsInCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CartItems");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Carts",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

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
        }
    }
}
