using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumBidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AuctionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuctionEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AuctionEndDate", "AuctionStartDate", "Category", "ImageUrl", "ItemCondition", "MinimumBidAmount", "ProductDescription", "ProductName" },
                values: new object[] { 1, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 20, 12, 40, 108, DateTimeKind.Local).AddTicks(2241), "Electronics", "https://example.com/images/product1.jpg", "New", 1000m, "Sony next-gen gaming console", "PlayStation 5" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AuctionEndDate", "AuctionStartDate", "Category", "ImageUrl", "ItemCondition", "MinimumBidAmount", "ProductDescription", "ProductName" },
                values: new object[] { 2, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 20, 12, 40, 108, DateTimeKind.Local).AddTicks(2277), "Shoes", "https://example.com/images/product2.jpg", "Used", 5000m, "2022 Sneaker of the Year", "Jordan 1 Lost and Found" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
