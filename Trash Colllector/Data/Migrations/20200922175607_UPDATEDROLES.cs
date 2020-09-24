using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Colllector.Data.Migrations
{
    public partial class UPDATEDROLES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "262496ef-a08e-4070-bddd-53d738e24c08");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49672cd9-038f-4903-9d2f-64923f257741", "1172ad64-0449-4ed1-ad9a-7008d45f437e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a62de7c-eadb-48b5-b177-4e7d0527488d", "16fec549-c4dd-4c12-b2a3-b802258a4745", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "262496ef-a08e-4070-bddd-53d738e24c08", "a9db1f47-4eb3-40f8-9da9-642d8cb4ab2b", "Admin", "ADMIN" });
        }
    }
}
