using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class SellerPhotoConfirm : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e93574d0-7209-4b7b-94f2-fd6016e4e2bc", "852d15fc-02e2-4ed0-829c-097435656123", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1840d30-44e3-4fcb-ad22-c2ba5007f7cb", "d57fc234-56eb-4d24-85c8-89469a760130", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1840d30-44e3-4fcb-ad22-c2ba5007f7cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e93574d0-7209-4b7b-94f2-fd6016e4e2bc");

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
