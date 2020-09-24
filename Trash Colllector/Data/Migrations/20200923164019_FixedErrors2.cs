using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Colllector.Data.Migrations
{
    public partial class FixedErrors2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dcb781-2ea7-4c15-b62b-6dd5ef479462");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3c7e0b9-2b8d-4e72-a0d3-9975edb7b766");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "isConfirmed",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba16ca40-5f81-4c65-83a5-d52ae5b31c3a", "46e344db-8d2b-4a7f-b8fa-957e51caf499", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "961b38ce-11bb-46b2-9924-88be649142ed", "f209f770-efca-48ff-8ee6-37e80ab89d8d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "961b38ce-11bb-46b2-9924-88be649142ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba16ca40-5f81-4c65-83a5-d52ae5b31c3a");

            migrationBuilder.DropColumn(
                name: "isConfirmed",
                table: "Customers");

            migrationBuilder.AlterColumn<double>(
                name: "ZipCode",
                table: "Employees",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3c7e0b9-2b8d-4e72-a0d3-9975edb7b766", "5eb6e4c1-c0c1-4047-b06d-0036f5aff83f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24dcb781-2ea7-4c15-b62b-6dd5ef479462", "e2f13ee6-ec08-4e78-b7e9-eccc783bc82a", "Employee", "EMPLOYEE" });
        }
    }
}
