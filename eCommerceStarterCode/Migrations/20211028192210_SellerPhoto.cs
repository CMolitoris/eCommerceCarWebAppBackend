using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class SellerPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcf8f25f-a198-4bb0-a6f5-108a78754e6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5106964-1198-4a87-b6a2-c1a2cc39897c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65fe841f-3409-4289-813b-136181acf78a", "9b52c94f-51f9-48df-bc77-0d9493ee0115", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f27a5f26-7bc7-444a-a793-3ef262f9b97c", "73f3d483-259c-4550-ac40-82b787881220", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65fe841f-3409-4289-813b-136181acf78a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f27a5f26-7bc7-444a-a793-3ef262f9b97c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bcf8f25f-a198-4bb0-a6f5-108a78754e6c", "2dc9433e-8bad-4056-807c-2efa3b889d55", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5106964-1198-4a87-b6a2-c1a2cc39897c", "878770b2-87a5-4e34-9472-c344c2637445", "Admin", "ADMIN" });
        }
    }
}
