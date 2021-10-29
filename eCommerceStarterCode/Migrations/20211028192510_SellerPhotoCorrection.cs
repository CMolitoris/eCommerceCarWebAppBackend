using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class SellerPhotoCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65fe841f-3409-4289-813b-136181acf78a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f27a5f26-7bc7-444a-a793-3ef262f9b97c");

            migrationBuilder.CreateTable(
                name: "SellerPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellerPhotos_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76b43aa9-efaf-41f8-b903-61f776829e05", "c5bbd158-61fb-43ec-b665-87be091e108e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "efd76f48-cb37-4b33-9ae8-4681aa54c5d9", "e6ed5008-ea4e-4823-a412-1765adf2d8cf", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_SellerPhotos_CarId",
                table: "SellerPhotos",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellerPhotos");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76b43aa9-efaf-41f8-b903-61f776829e05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efd76f48-cb37-4b33-9ae8-4681aa54c5d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65fe841f-3409-4289-813b-136181acf78a", "9b52c94f-51f9-48df-bc77-0d9493ee0115", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f27a5f26-7bc7-444a-a793-3ef262f9b97c", "73f3d483-259c-4550-ac40-82b787881220", "Admin", "ADMIN" });
        }
    }
}
