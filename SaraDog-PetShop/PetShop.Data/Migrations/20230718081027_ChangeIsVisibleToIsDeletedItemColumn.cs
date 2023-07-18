using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class ChangeIsVisibleToIsDeletedItemColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsVisible",
                table: "Items",
                newName: "IsDeleted");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4253), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4301), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4305), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4310), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4315), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4319), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4322), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4325), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4331), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4334), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4338), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4342), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4345), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4348), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4351), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4355), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4358), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4361), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4366), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "IsDeleted", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4369), false, new DateTime(2023, 7, 18, 11, 10, 26, 965, DateTimeKind.Local).AddTicks(4370) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Items",
                newName: "IsVisible");

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
    }
}
