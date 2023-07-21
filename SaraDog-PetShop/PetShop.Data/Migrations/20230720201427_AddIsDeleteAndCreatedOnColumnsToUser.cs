using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class AddIsDeleteAndCreatedOnColumnsToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsManager",
                table: "AspNetUsers",
                newName: "IsModerator");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "IsModerator",
                table: "AspNetUsers",
                newName: "IsManager");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9856), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9913), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9930), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9934), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9937), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9941), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9944), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9951), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9955), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9970), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9973), new DateTime(2023, 7, 20, 13, 51, 30, 261, DateTimeKind.Local).AddTicks(9975) });
        }
    }
}
