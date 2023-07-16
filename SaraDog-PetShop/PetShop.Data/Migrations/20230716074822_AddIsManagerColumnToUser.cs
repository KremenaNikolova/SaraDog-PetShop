using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddIsManagerColumnToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsManager",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(854), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(899), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(903), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(907), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(912), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(915), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(918), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(922), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(926), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(929), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(933), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(937), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(940), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(943), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(946), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(949), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(953), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(956), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(960), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(964), new DateTime(2023, 7, 16, 10, 48, 22, 629, DateTimeKind.Local).AddTicks(965) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsManager",
                table: "AspNetUsers");

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
    }
}
