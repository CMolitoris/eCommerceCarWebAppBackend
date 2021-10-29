using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class PhotoRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76b43aa9-efaf-41f8-b903-61f776829e05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efd76f48-cb37-4b33-9ae8-4681aa54c5d9");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "SellerPhotos");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "SellerPhotos");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SellerPhotos",
                newName: "ImageResponseData");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a3578de-1791-4838-85bf-b99a3b064846", "b0fa20ce-f2f6-4f7b-8d97-b60e22e34a50", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "352f16a2-7c6d-43a1-b0c6-41dc07656adb", "057ca5af-58c2-4784-bffd-99add05b6666", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3578de-1791-4838-85bf-b99a3b064846");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "352f16a2-7c6d-43a1-b0c6-41dc07656adb");

            migrationBuilder.RenameColumn(
                name: "ImageResponseData",
                table: "SellerPhotos",
                newName: "Name");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "SellerPhotos",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "SellerPhotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76b43aa9-efaf-41f8-b903-61f776829e05", "c5bbd158-61fb-43ec-b665-87be091e108e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "efd76f48-cb37-4b33-9ae8-4681aa54c5d9", "e6ed5008-ea4e-4823-a412-1765adf2d8cf", "Admin", "ADMIN" });
        }
    }
}
