using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class FirstCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "697f089f-9197-4cb1-9155-de81b28102de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82e03552-5347-4a4e-a802-282487e31465");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd18e502-e42d-45a1-8cd9-ca4e8f2e4dbc", "2af3c619-7be5-4eb2-b713-a76d401f82c6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84d1ef10-058c-447f-bd68-f3a5bf91913c", "fbc750ac-5309-4896-963e-588feb663b5b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AverageRating", "Description", "Make", "Mileage", "Model", "Price" },
                values: new object[] { 1, 3.5, "Entry level sedan", "Ford", 25000, "Fusion", 24000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84d1ef10-058c-447f-bd68-f3a5bf91913c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd18e502-e42d-45a1-8cd9-ca4e8f2e4dbc");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "697f089f-9197-4cb1-9155-de81b28102de", "6efdb1f0-95b6-4b22-8c17-2c6c06f07596", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82e03552-5347-4a4e-a802-282487e31465", "ea85bed8-f14d-433f-87a7-f5939adff3d2", "Admin", "ADMIN" });
        }
    }
}
