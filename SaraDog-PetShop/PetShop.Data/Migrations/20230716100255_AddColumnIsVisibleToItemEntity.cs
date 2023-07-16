using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddColumnIsVisibleToItemEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Items",
                newName: "IsActive");

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1783), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1828), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1832), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1836), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1842), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1845), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1850), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1853), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1859), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1862), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1866), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1870), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1873), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1876), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1879), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1883), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1886), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1890), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1894), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "IsVisible", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1898), true, new DateTime(2023, 7, 16, 13, 2, 55, 640, DateTimeKind.Local).AddTicks(1899) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Items",
                newName: "isActive");

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
    }
}
