using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AdditionUserEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Orders",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Orders",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Orders",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(49)",
                maxLength: 49,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(49)",
                maxLength: 49,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2302), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2329), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2332), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2335), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2339), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2342), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2357), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2365), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 7, 24, 10, 20, 30, 963, DateTimeKind.Local).AddTicks(2369) });
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

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1500)",
                oldMaxLength: 1500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(49)",
                oldMaxLength: 49,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Items",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

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
