using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddressImageUserFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5488), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5539), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5594), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5602), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5612), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5616), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5623), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5626), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5629), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5633), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5637), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5641), new DateTime(2023, 7, 21, 9, 48, 30, 637, DateTimeKind.Local).AddTicks(5642) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6488), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6541), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6549), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6555), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6558), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6562), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6565), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6573), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6577), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6584), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6592), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6595), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6598), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6602), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6636), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 7, 20, 23, 14, 27, 672, DateTimeKind.Local).AddTicks(6641) });
        }
    }
}
