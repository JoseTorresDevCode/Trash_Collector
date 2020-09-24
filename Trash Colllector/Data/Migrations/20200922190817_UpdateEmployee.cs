using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Colllector.Data.Migrations
{
    public partial class UpdateEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49672cd9-038f-4903-9d2f-64923f257741");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a62de7c-eadb-48b5-b177-4e7d0527488d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "78556972-75f0-4967-a31d-4cc4384d1b01", "7b676334-63f7-4e53-9ba7-ae375206460f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0348c9f-629e-4910-8bb5-c4f97bd3ccbf", "4705fb18-2db8-42f3-9035-6035aade2628", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78556972-75f0-4967-a31d-4cc4384d1b01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0348c9f-629e-4910-8bb5-c4f97bd3ccbf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49672cd9-038f-4903-9d2f-64923f257741", "1172ad64-0449-4ed1-ad9a-7008d45f437e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a62de7c-eadb-48b5-b177-4e7d0527488d", "16fec549-c4dd-4c12-b2a3-b802258a4745", "Employee", "Employee" });
        }
    }
}
