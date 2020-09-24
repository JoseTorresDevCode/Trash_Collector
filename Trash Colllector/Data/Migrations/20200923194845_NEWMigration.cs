using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Colllector.Data.Migrations
{
    public partial class NEWMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "961b38ce-11bb-46b2-9924-88be649142ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba16ca40-5f81-4c65-83a5-d52ae5b31c3a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "882c8242-e304-4aa2-821e-cb6bfa4c84d1", "f6f246e5-4679-48fc-a71a-855182bae092", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a032a71-5dff-4296-85b8-39297b96b33a", "2c1f36b0-3e25-453d-9e84-c3769649b7c0", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a032a71-5dff-4296-85b8-39297b96b33a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "882c8242-e304-4aa2-821e-cb6bfa4c84d1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba16ca40-5f81-4c65-83a5-d52ae5b31c3a", "46e344db-8d2b-4a7f-b8fa-957e51caf499", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "961b38ce-11bb-46b2-9924-88be649142ed", "f209f770-efca-48ff-8ee6-37e80ab89d8d", "Employee", "EMPLOYEE" });
        }
    }
}
