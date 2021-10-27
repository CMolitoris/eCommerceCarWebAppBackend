using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class SCFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "336cd29c-5591-435d-b131-546754ae4c06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5252c756-ad3c-486b-9799-a4523179d294");

            migrationBuilder.CreateTable(
                name: "SellerConnections",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerConnections", x => new { x.UserId, x.CarId });
                    table.ForeignKey(
                        name: "FK_SellerConnections_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SellerConnections_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca111014-8f3d-4f31-b19d-0925a54c59a6", "10c642ce-f258-4085-9176-296ab8798864", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "770de7ea-5bca-4050-8aa6-01ac5b37bc32", "57eaf5fd-91f4-46e9-ac0e-db6c0c250c7c", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_SellerConnections_CarId",
                table: "SellerConnections",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellerConnections");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770de7ea-5bca-4050-8aa6-01ac5b37bc32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca111014-8f3d-4f31-b19d-0925a54c59a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "336cd29c-5591-435d-b131-546754ae4c06", "e93f1404-49b7-4e35-b66b-3254aedf792a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5252c756-ad3c-486b-9799-a4523179d294", "f2b6eece-fb21-4091-bb1c-11c80ab9a910", "Admin", "ADMIN" });
        }
    }
}
