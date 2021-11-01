using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class StockCarImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fd0ce77-9ea7-4b7e-9a48-b8c4695cc589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3ff77ad-e9ac-4b98-98d3-7bcf06ded108");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1084fab3-9c51-4650-80ef-e306b5e8082f", "33486abe-5643-4085-be31-6c026cb2a97b", "User", "USER" },
                    { "289190e4-5915-48d3-869c-08e5f03f4798", "8943ed21-1394-4550-8e36-e2280e1f6843", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "staticImages\\2022-hyundai-elantra.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "staticImages\\2022-toyota-camry.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "staticImages\\2022-lexus-es.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "staticImages\\2022-toyota-rav4.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "staticImages\\2022-kia-sorento.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "staticImages\\2022-ford-expedition.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "staticImages\\2022-toyota-sienna.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "staticImages\\2022-honda-odyssey.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "staticImages\\2022-chrysler-pacifica.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Make", "Model", "Price", "Type" },
                values: new object[] { "Entry level pickup truck.", "staticImages\\2022-ford-f-150.jpg", "Ford", "F-150", 38000.0, "Truck" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Image", "Make", "Model", "Price" },
                values: new object[] { "staticImages\\2022-ram-1500.jpg", "Ram", "1500", 36000.0 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Image", "Make", "Model" },
                values: new object[] { "staticImages\\2022-chevrolet-silverado.jpg", "Chevrolet", "Silverado 1500" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1084fab3-9c51-4650-80ef-e306b5e8082f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "289190e4-5915-48d3-869c-08e5f03f4798");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c3ff77ad-e9ac-4b98-98d3-7bcf06ded108", "7b0827f4-9048-42ee-be22-52896045dc8a", "User", "USER" },
                    { "7fd0ce77-9ea7-4b7e-9a48-b8c4695cc589", "6b7bc26e-72ad-4c1e-b1f7-f9c7f7fabec5", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Make", "Model", "Price", "Type" },
                values: new object[] { "Entry level Minivan.", "Toyota", "Sienna", 35000.0, "Minivan" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Make", "Model", "Price" },
                values: new object[] { "Ford", "F-150", 38000.0 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Make", "Model" },
                values: new object[] { "Ram", "1500" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Description", "Make", "Mileage", "Model", "Price", "Type", "Year" },
                values: new object[] { 13, "Entry level pickup truck.", "Chevrolet", 0, "Silverado 1500", 36000.0, "Truck", 2022 });
        }
    }
}
