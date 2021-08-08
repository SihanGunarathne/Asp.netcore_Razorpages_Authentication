using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Booking_Tourism.Migrations
{
    public partial class sfdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "22c2486e-e568-4ed5-9c9b-55ea97d074f9", "8e07a104-d837-4e60-8209-a41823bbf40d", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dfcbb005-d7e7-4d89-a514-67de0d8fefca", "6e0c6dbd-5ce1-4408-82f3-8786aede39c6", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22c2486e-e568-4ed5-9c9b-55ea97d074f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfcbb005-d7e7-4d89-a514-67de0d8fefca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b3d1255-246b-42dd-9413-63644ceabee0", "7afe3bd5-5e9d-4de4-8a4b-f6a2733382c3", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39afb6d0-1835-49e1-949a-4f266870a57f", "7823e3e3-2eda-4927-8094-13cc70dd1720", "Administrator", "ADMINISTRATOR" });
        }
    }
}
