using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseAppWebApi.Migrations
{
    public partial class roleDataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6dfa0d64-c429-402e-8e0f-8379a29d5cb0", "eb771d83-dfc7-4103-9b34-a93ae01f1096", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bca62221-5e2d-4f37-97d3-6350a696f8e7", "bb58daf2-d5d2-4380-86a9-afccdaa54ba8", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6dfa0d64-c429-402e-8e0f-8379a29d5cb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bca62221-5e2d-4f37-97d3-6350a696f8e7");
        }
    }
}
