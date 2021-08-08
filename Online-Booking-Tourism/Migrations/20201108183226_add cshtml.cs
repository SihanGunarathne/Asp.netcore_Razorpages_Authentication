using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Booking_Tourism.Migrations
{
    public partial class addcshtml : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e5a9897-ac05-413b-806d-f3ad338f36a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e9911c1-c7c6-448e-95a7-7d9dc6bd84ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "566d328e-c833-48fa-9f9f-38ab35c7bd54", "467cf34e-d134-4588-a611-2b8f6b25a1dd", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c04a194-4f65-49a8-be5f-334fc1e06941", "0a0154dc-6536-4e86-b421-e8b6021e363b", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c04a194-4f65-49a8-be5f-334fc1e06941");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "566d328e-c833-48fa-9f9f-38ab35c7bd54");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e5a9897-ac05-413b-806d-f3ad338f36a7", "87fa47b4-3c70-4018-bbcd-9c4be0bdd81f", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e9911c1-c7c6-448e-95a7-7d9dc6bd84ea", "651a2fbc-d0b0-4f73-a542-8abaf7486906", "Administrator", "ADMINISTRATOR" });
        }
    }
}
