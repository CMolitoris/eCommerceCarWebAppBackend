using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class CarModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47e25dd6-a1a2-49a6-af6f-0a305b516e67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "848eb36c-4c65-4966-be2a-770791144652");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a02c746-f242-4666-9f28-833fe2c116d8", "206a021b-62c5-4e66-a7ac-bb364022daf3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "770cf931-bfb7-4247-a54e-45bf3ef7e87e", "c730e78a-42e2-40cd-aa5a-ee69616e887d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770cf931-bfb7-4247-a54e-45bf3ef7e87e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a02c746-f242-4666-9f28-833fe2c116d8");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "848eb36c-4c65-4966-be2a-770791144652", "038aa2b0-9a00-49d8-95fe-294714743b65", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47e25dd6-a1a2-49a6-af6f-0a305b516e67", "925da2ac-dca5-4019-9b4a-348327a1823d", "Admin", "ADMIN" });
        }
    }
}
