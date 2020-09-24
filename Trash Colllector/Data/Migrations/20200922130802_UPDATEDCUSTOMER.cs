using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Colllector.Data.Migrations
{
    public partial class UPDATEDCUSTOMER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b58f7ebd-aec7-4a12-b81e-137f6ae3677d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc2242b7-db49-463d-9ec4-7931e70a0e26");

            migrationBuilder.AddColumn<string>(
                name: "zipCode",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "balance",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "oneTimePickUp",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0cc28e18-7cdf-4201-b8b0-2a27fdc54376", "35885d24-2869-4d6c-833a-c719afca9955", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5316371e-8d48-44f6-9f47-2b6b33cfb771", "bca17486-ae9b-4a6c-b194-99a5e5e22fd0", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cc28e18-7cdf-4201-b8b0-2a27fdc54376");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5316371e-8d48-44f6-9f47-2b6b33cfb771");

            migrationBuilder.DropColumn(
                name: "zipCode",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "balance",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "oneTimePickUp",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc2242b7-db49-463d-9ec4-7931e70a0e26", "b2c93302-5d2a-4cdb-84da-aada257754e9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b58f7ebd-aec7-4a12-b81e-137f6ae3677d", "27441b65-f8f3-44fb-ba59-bf2572cb49a4", "Employee", "EMPLOYEE" });
        }
    }
}
