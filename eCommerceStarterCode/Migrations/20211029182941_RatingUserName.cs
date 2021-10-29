using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class RatingUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3578de-1791-4838-85bf-b99a3b064846");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "352f16a2-7c6d-43a1-b0c6-41dc07656adb");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46f6c47e-fbc5-46f2-b4a7-49b448c20d58", "20966f80-e055-4513-908a-7084ea7e3ac9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96ea4171-05f7-4923-a06f-b5baa3f8e189", "7a555bf2-8445-47b9-856b-8a9cd06650e9", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46f6c47e-fbc5-46f2-b4a7-49b448c20d58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ea4171-05f7-4923-a06f-b5baa3f8e189");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Ratings");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a3578de-1791-4838-85bf-b99a3b064846", "b0fa20ce-f2f6-4f7b-8d97-b60e22e34a50", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "352f16a2-7c6d-43a1-b0c6-41dc07656adb", "057ca5af-58c2-4784-bffd-99add05b6666", "Admin", "ADMIN" });
        }
    }
}
