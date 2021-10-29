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
                keyValue: "46f6c47e-fbc5-46f2-b4a7-49b448c20d58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ea4171-05f7-4923-a06f-b5baa3f8e189");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "SellerPhotos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3ff77ad-e9ac-4b98-98d3-7bcf06ded108", "7b0827f4-9048-42ee-be22-52896045dc8a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7fd0ce77-9ea7-4b7e-9a48-b8c4695cc589", "6b7bc26e-72ad-4c1e-b1f7-f9c7f7fabec5", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_SellerPhotos_UserId",
                table: "SellerPhotos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SellerPhotos_AspNetUsers_UserId",
                table: "SellerPhotos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SellerPhotos_AspNetUsers_UserId",
                table: "SellerPhotos");

            migrationBuilder.DropIndex(
                name: "IX_SellerPhotos_UserId",
                table: "SellerPhotos");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fd0ce77-9ea7-4b7e-9a48-b8c4695cc589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3ff77ad-e9ac-4b98-98d3-7bcf06ded108");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SellerPhotos");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46f6c47e-fbc5-46f2-b4a7-49b448c20d58", "20966f80-e055-4513-908a-7084ea7e3ac9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96ea4171-05f7-4923-a06f-b5baa3f8e189", "7a555bf2-8445-47b9-856b-8a9cd06650e9", "Admin", "ADMIN" });
        }
    }
}
