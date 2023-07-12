using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddIsActiveItemColumnForSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6758), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6766), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6767), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6770), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6774), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6775), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6776), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6813), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6816), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6817), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6818), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6819), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6821), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6822), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6824), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6825), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6826), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6827), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6830), true });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "isActive" },
                values: new object[] { new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6831), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 17, 12, 4, 403, DateTimeKind.Utc).AddTicks(8242));
        }
    }
}
