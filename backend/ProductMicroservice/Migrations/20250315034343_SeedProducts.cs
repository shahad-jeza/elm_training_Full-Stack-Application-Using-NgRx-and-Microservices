using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace product.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Electronics", "High-performance laptop", "Laptop", 1200.00m },
                    { 2, "Electronics", "Latest smartphone model", "Smartphone", 800.00m },
                    { 3, "Electronics", "Portable tablet device", "Tablet", 500.00m },
                    { 4, "Electronics", "Noise-cancelling headphones", "Headphones", 150.00m },
                    { 5, "Electronics", "Fitness tracking smartwatch", "Smartwatch", 250.00m },
                    { 6, "Electronics", "27-inch 4K monitor", "Monitor", 400.00m },
                    { 7, "Electronics", "Mechanical gaming keyboard", "Keyboard", 120.00m },
                    { 8, "Electronics", "Wireless ergonomic mouse", "Mouse", 80.00m },
                    { 9, "Electronics", "All-in-one laser printer", "Printer", 300.00m },
                    { 10, "Electronics", "DSLR camera with 24MP", "Camera", 700.00m },
                    { 11, "Electronics", "Bluetooth portable speaker", "Speaker", 100.00m },
                    { 12, "Electronics", "4K HD drone with camera", "Drone", 600.00m },
                    { 13, "Electronics", "Wi-Fi 6 router", "Router", 200.00m },
                    { 14, "Electronics", "1TB portable SSD", "External SSD", 150.00m },
                    { 15, "Electronics", "Next-gen gaming console", "Gaming Console", 500.00m },
                    { 16, "Home Appliances", "Automatic drip coffee maker", "Coffee Maker", 80.00m },
                    { 17, "Home Appliances", "High-speed blender", "Blender", 120.00m },
                    { 18, "Home Appliances", "Compact microwave oven", "Microwave", 150.00m },
                    { 19, "Home Appliances", "4-slice toaster", "Toaster", 50.00m },
                    { 20, "Home Appliances", "Bagless vacuum cleaner", "Vacuum Cleaner", 200.00m },
                    { 21, "Home Appliances", "HEPA air purifier", "Air Purifier", 250.00m },
                    { 22, "Home Appliances", "Stainless steel electric kettle", "Electric Kettle", 40.00m },
                    { 23, "Home Appliances", "Automatic rice cooker", "Rice Cooker", 60.00m },
                    { 24, "Home & Office", "LED desk lamp", "Desk Lamp", 40.00m },
                    { 25, "Home & Office", "Ergonomic office chair", "Office Chair", 200.00m },
                    { 26, "Home & Office", "Adjustable standing desk", "Desk", 300.00m },
                    { 27, "Stationery", "Spiral-bound notebook", "Notebook", 5.00m },
                    { 28, "Stationery", "Ballpoint pen (pack of 10)", "Pen", 10.00m },
                    { 29, "Stationery", "Heavy-duty stapler", "Stapler", 15.00m },
                    { 30, "Home & Office", "Cross-cut paper shredder", "Paper Shredder", 100.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
