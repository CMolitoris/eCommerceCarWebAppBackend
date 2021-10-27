using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class SellerConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a38c6617-1103-462b-8a9c-2bcd3ccd430a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bff2d13e-b359-447b-b5ca-b25fb9d8cbf2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "336cd29c-5591-435d-b131-546754ae4c06", "e93f1404-49b7-4e35-b66b-3254aedf792a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5252c756-ad3c-486b-9799-a4523179d294", "f2b6eece-fb21-4091-bb1c-11c80ab9a910", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "336cd29c-5591-435d-b131-546754ae4c06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5252c756-ad3c-486b-9799-a4523179d294");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bff2d13e-b359-447b-b5ca-b25fb9d8cbf2", "4d07b6d8-06a6-4304-be91-01ea47460e87", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a38c6617-1103-462b-8a9c-2bcd3ccd430a", "2ffe3f81-37a2-4aeb-abdc-1da16004dd92", "Admin", "ADMIN" });
        }
    }
}
