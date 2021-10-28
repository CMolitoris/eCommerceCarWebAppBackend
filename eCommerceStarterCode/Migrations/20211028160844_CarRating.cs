using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class CarRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770de7ea-5bca-4050-8aa6-01ac5b37bc32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca111014-8f3d-4f31-b19d-0925a54c59a6");

            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bcf8f25f-a198-4bb0-a6f5-108a78754e6c", "2dc9433e-8bad-4056-807c-2efa3b889d55", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5106964-1198-4a87-b6a2-c1a2cc39897c", "878770b2-87a5-4e34-9472-c344c2637445", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcf8f25f-a198-4bb0-a6f5-108a78754e6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5106964-1198-4a87-b6a2-c1a2cc39897c");

            migrationBuilder.AddColumn<double>(
                name: "AverageRating",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca111014-8f3d-4f31-b19d-0925a54c59a6", "10c642ce-f258-4085-9176-296ab8798864", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "770de7ea-5bca-4050-8aa6-01ac5b37bc32", "57eaf5fd-91f4-46e9-ac0e-db6c0c250c7c", "Admin", "ADMIN" });
        }
    }
}
