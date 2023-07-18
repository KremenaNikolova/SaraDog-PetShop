using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddQuantityColumnInCarItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9569), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9617), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9622), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9625), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9631), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9634), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9638), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9646), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9683), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9693), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9703), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9708), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9711), new DateTime(2023, 7, 18, 22, 16, 56, 841, DateTimeKind.Local).AddTicks(9712) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CartItems");

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
