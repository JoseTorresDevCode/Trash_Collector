using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Colllector.Data.Migrations
{
    public partial class FixedSyntaxErrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "76f33ffd-fdcc-4883-ab75-b5cf748ca45d", "207cb46b-dd2c-4260-92dd-a8626065fb82", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe9a966b-9dd1-45ba-adc0-b22de43e4c7f", "830a1340-0734-419f-bdc3-d234d7127fb1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef60e7bb-f885-4461-af70-e4d5c5accffe", "88d7e97a-b27a-4641-a191-5ceb528d1e5b", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76f33ffd-fdcc-4883-ab75-b5cf748ca45d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef60e7bb-f885-4461-af70-e4d5c5accffe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe9a966b-9dd1-45ba-adc0-b22de43e4c7f");

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
    }
}
