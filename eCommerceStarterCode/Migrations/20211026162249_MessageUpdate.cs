using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class MessageUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ac8d5a9-35b5-4030-93c9-4bb84874a6e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a82b38cf-b710-49bd-a166-4c906e5c22ff");

            migrationBuilder.RenameColumn(
                name: "RatingId",
                table: "Ratings",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "RatingScore",
                table: "Ratings",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "848eb36c-4c65-4966-be2a-770791144652", "038aa2b0-9a00-49d8-95fe-294714743b65", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47e25dd6-a1a2-49a6-af6f-0a305b516e67", "925da2ac-dca5-4019-9b4a-348327a1823d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47e25dd6-a1a2-49a6-af6f-0a305b516e67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "848eb36c-4c65-4966-be2a-770791144652");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ratings",
                newName: "RatingId");

            migrationBuilder.AlterColumn<int>(
                name: "RatingScore",
                table: "Ratings",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ac8d5a9-35b5-4030-93c9-4bb84874a6e8", "7d20383d-3ea4-4bb9-8b9b-95405434e433", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a82b38cf-b710-49bd-a166-4c906e5c22ff", "26e9b6a0-7d7f-4544-9d39-525b07123a5d", "Admin", "ADMIN" });
        }
    }
}
