using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Data.Migrations
{
    public partial class IsDeletedPropertyInCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4382), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4386), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4391), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4399), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4403), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4414), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4417), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4421), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4424), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4435), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AddedOn", "LastEdit" },
                values: new object[] { new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4446), new DateTime(2023, 7, 20, 15, 59, 15, 959, DateTimeKind.Local).AddTicks(4447) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

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
