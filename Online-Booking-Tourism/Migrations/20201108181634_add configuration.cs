using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Booking_Tourism.Migrations
{
    public partial class addconfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "700128ac-1c3f-441c-a2dc-84e6ba5aff65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c312a60-5a76-4f40-9371-f44933b740ae");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, 9876L, "Mark Miens" },
                    { 2, 1234L, "Anna Miens" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b5e2134-7084-4a38-b437-7bbc910a264e", "9c377bd0-ee01-44c8-abd7-e1af0ed3970c", "Visitor", "VISITOR" },
                    { "d784aafe-aa06-44f7-acb5-cf605d7afd2b", "5b588496-2ac9-4319-82f0-cc43306ae52c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Guiders",
                columns: new[] { "Id", "GuiderName", "Place", "Price", "TelephoneNumber" },
                values: new object[,]
                {
                    { 1, "Mark Miens", "colombo", 5000, "0710000000" },
                    { 2, "Anna Miens", "colombo", 6000, "0710000002" }
                });

            migrationBuilder.InsertData(
                table: "Travelers",
                columns: new[] { "Id", "Place", "TelephoneNumber", "TravellerName", "TravellingDate" },
                values: new object[,]
                {
                    { 1, "colombo", "0710000000", "Mark Miens", "30/11/2020" },
                    { 2, "colombo", "0710000000", "Anna Miens", "30/11/2020" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b5e2134-7084-4a38-b437-7bbc910a264e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d784aafe-aa06-44f7-acb5-cf605d7afd2b");

            migrationBuilder.DeleteData(
                table: "Guiders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guiders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Travelers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Travelers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c312a60-5a76-4f40-9371-f44933b740ae", "865cf28f-3871-4b30-bf65-d1b03acf62df", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "700128ac-1c3f-441c-a2dc-84e6ba5aff65", "0f353c8e-1fd4-4e23-a611-92c10e4bec52", "Administrator", "ADMINISTRATOR" });
        }
    }
}
