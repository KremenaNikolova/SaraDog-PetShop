using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class ChanginPictureUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "TitleImage" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1420), "~/Images/Ball.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1554));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "TitleImage" },
                values: new object[] { new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8336), "C:\\Users\\aradi\\OneDrive\\SaraDog-PetShop\\SaraDog-PetShop\\PetShop.Web\\wwwroot\\Images\\MinionDress.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 10, 56, 536, DateTimeKind.Utc).AddTicks(8437));
        }
    }
}
