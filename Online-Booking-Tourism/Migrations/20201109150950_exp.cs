using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Booking_Tourism.Migrations
{
    public partial class exp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c7241cf4-1d9f-458e-a00e-f07eda0bd885", "c63572ff-803b-47f8-bd5d-096e7feaebbb", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "448e24c2-5e3d-4e23-bc38-86ca0517077b", "cc716fdd-c699-4b33-95a2-e7b0165ef2b4", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "448e24c2-5e3d-4e23-bc38-86ca0517077b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7241cf4-1d9f-458e-a00e-f07eda0bd885");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "566d328e-c833-48fa-9f9f-38ab35c7bd54", "467cf34e-d134-4588-a611-2b8f6b25a1dd", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c04a194-4f65-49a8-be5f-334fc1e06941", "0a0154dc-6536-4e86-b421-e8b6021e363b", "Administrator", "ADMINISTRATOR" });
        }
    }
}
