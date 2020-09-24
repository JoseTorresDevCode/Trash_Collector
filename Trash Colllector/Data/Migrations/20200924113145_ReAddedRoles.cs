using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Colllector.Data.Migrations
{
    public partial class ReAddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc294f4a-41d4-429f-9973-c0b2bd8b3f00");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d757200a-8f0f-4d43-af63-f024e410d276", "2b17350b-e6b4-473b-95b1-6db753b4683d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51be01ff-d0ee-44e5-b3cd-f53e52cff8bc", "7fc37e73-2689-4771-b89a-9a4b6d60444f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ceb4c5ab-8872-4619-b68b-430a8ec668d0", "39da9407-e661-4fc1-a638-3545feb20b4c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51be01ff-d0ee-44e5-b3cd-f53e52cff8bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceb4c5ab-8872-4619-b68b-430a8ec668d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d757200a-8f0f-4d43-af63-f024e410d276");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc294f4a-41d4-429f-9973-c0b2bd8b3f00", "15ed6966-8930-41ad-9092-1bd280d7e768", "Admin", "ADMIN" });
        }
    }
}
