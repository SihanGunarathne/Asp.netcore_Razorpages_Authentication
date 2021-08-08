using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Booking_Tourism.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b5e2134-7084-4a38-b437-7bbc910a264e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d784aafe-aa06-44f7-acb5-cf605d7afd2b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e5a9897-ac05-413b-806d-f3ad338f36a7", "87fa47b4-3c70-4018-bbcd-9c4be0bdd81f", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e9911c1-c7c6-448e-95a7-7d9dc6bd84ea", "651a2fbc-d0b0-4f73-a542-8abaf7486906", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2b5e2134-7084-4a38-b437-7bbc910a264e", "9c377bd0-ee01-44c8-abd7-e1af0ed3970c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d784aafe-aa06-44f7-acb5-cf605d7afd2b", "5b588496-2ac9-4319-82f0-cc43306ae52c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
