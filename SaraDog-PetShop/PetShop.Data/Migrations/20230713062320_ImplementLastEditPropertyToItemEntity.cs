using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class ImplementLastEditPropertyToItemEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastEdit",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8001), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8048), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8052), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8056), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8061), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8064), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8071), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8076), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8109), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8116), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8119), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8122), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8129), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8135), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8143), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8146), new DateTime(2023, 7, 13, 9, 23, 20, 171, DateTimeKind.Local).AddTicks(8147) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastEdit",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 18, 18, 11, 423, DateTimeKind.Utc).AddTicks(6831));
        }
    }
}
