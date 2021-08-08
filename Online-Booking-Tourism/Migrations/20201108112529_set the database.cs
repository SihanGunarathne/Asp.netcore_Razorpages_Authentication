using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Booking_Tourism.Migrations
{
    public partial class setthedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59717c95-d85b-4754-a6f8-744512f143e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbad5a6-2e12-40db-a261-e094c4f3fe44");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b3d1255-246b-42dd-9413-63644ceabee0", "7afe3bd5-5e9d-4de4-8a4b-f6a2733382c3", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39afb6d0-1835-49e1-949a-4f266870a57f", "7823e3e3-2eda-4927-8094-13cc70dd1720", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39afb6d0-1835-49e1-949a-4f266870a57f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b3d1255-246b-42dd-9413-63644ceabee0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8cbad5a6-2e12-40db-a261-e094c4f3fe44", "613bc03d-0ab1-4680-ad51-3a007590ec76", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59717c95-d85b-4754-a6f8-744512f143e0", "e4ef0434-f92d-4f69-a205-379d1ddf6aa8", "Administrator", "ADMINISTRATOR" });
        }
    }
}
