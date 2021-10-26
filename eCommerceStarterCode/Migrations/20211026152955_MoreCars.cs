using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class MoreCars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84d1ef10-058c-447f-bd68-f3a5bf91913c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd18e502-e42d-45a1-8cd9-ca4e8f2e4dbc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17e1eb43-1247-40a6-8a91-0cab64ab0594", "361d4642-2e45-4c3a-b859-6768b6853b05", "User", "USER" },
                    { "61ca2629-1102-4696-a63d-c80c5820a6cf", "b01fbd06-72f9-40c4-9ca8-4f26b263e3b7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AverageRating", "Description", "Make", "Mileage", "Model", "Price" },
                values: new object[,]
                {
                    { 2, 3.7000000000000002, "Used 2015 Dodge Durango", "Dodge", 95000, "Durango", 20000.0 },
                    { 3, 4.2000000000000002, "Used Chevy Tahoe SUV", "Chevrolet", 40000, "Tahoe", 45000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17e1eb43-1247-40a6-8a91-0cab64ab0594");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61ca2629-1102-4696-a63d-c80c5820a6cf");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd18e502-e42d-45a1-8cd9-ca4e8f2e4dbc", "2af3c619-7be5-4eb2-b713-a76d401f82c6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84d1ef10-058c-447f-bd68-f3a5bf91913c", "fbc750ac-5309-4896-963e-588feb663b5b", "Admin", "ADMIN" });
        }
    }
}
