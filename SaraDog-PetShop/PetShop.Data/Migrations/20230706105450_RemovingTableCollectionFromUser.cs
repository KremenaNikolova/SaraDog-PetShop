using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class RemovingTableCollectionFromUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_AspNetUsers_ApplicationUserId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ApplicationUserId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 54, 50, 744, DateTimeKind.Utc).AddTicks(8921));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "Items",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 6, 10, 20, 10, 393, DateTimeKind.Utc).AddTicks(1420));

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

            migrationBuilder.CreateIndex(
                name: "IX_Items_ApplicationUserId",
                table: "Items",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AspNetUsers_ApplicationUserId",
                table: "Items",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
