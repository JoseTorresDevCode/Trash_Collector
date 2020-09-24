using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Colllector.Data.Migrations
{
    public partial class FixedErrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_IndentityUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_IndentityUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IndentityUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_IndentityUserId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78556972-75f0-4967-a31d-4cc4384d1b01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0348c9f-629e-4910-8bb5-c4f97bd3ccbf");

            migrationBuilder.DropColumn(
                name: "IndentityUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IndentityUserId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "Employees",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "Customers",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Customers",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "pickUpDay",
                table: "Customers",
                newName: "PickUpDay");

            migrationBuilder.RenameColumn(
                name: "oneTimePickUp",
                table: "Customers",
                newName: "OneTimePickUp");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "balance",
                table: "Customers",
                newName: "Balance");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Customers",
                newName: "Address");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3c7e0b9-2b8d-4e72-a0d3-9975edb7b766", "5eb6e4c1-c0c1-4047-b06d-0036f5aff83f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24dcb781-2ea7-4c15-b62b-6dd5ef479462", "e2f13ee6-ec08-4e78-b7e9-eccc783bc82a", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_IdentityUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24dcb781-2ea7-4c15-b62b-6dd5ef479462");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3c7e0b9-2b8d-4e72-a0d3-9975edb7b766");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Employees",
                newName: "zipCode");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Customers",
                newName: "zipCode");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Customers",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "PickUpDay",
                table: "Customers",
                newName: "pickUpDay");

            migrationBuilder.RenameColumn(
                name: "OneTimePickUp",
                table: "Customers",
                newName: "oneTimePickUp");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "Customers",
                newName: "balance");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customers",
                newName: "address");

            migrationBuilder.AddColumn<string>(
                name: "IndentityUserId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndentityUserId",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "78556972-75f0-4967-a31d-4cc4384d1b01", "7b676334-63f7-4e53-9ba7-ae375206460f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0348c9f-629e-4910-8bb5-c4f97bd3ccbf", "4705fb18-2db8-42f3-9035-6035aade2628", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IndentityUserId",
                table: "Employees",
                column: "IndentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IndentityUserId",
                table: "Customers",
                column: "IndentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_IndentityUserId",
                table: "Customers",
                column: "IndentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_IndentityUserId",
                table: "Employees",
                column: "IndentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
