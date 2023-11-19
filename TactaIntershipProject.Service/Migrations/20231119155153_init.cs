using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TactaIntershipProject.Service.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Shoppers",
                columns: table => new
                {
                    ShopperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopperName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoppers", x => x.ShopperId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingLists",
                columns: table => new
                {
                    ShoppingListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopperId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingLists", x => x.ShoppingListId);
                    table.ForeignKey(
                        name: "FK_ShoppingLists_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingLists_Shoppers_ShopperId",
                        column: x => x.ShopperId,
                        principalTable: "Shoppers",
                        principalColumn: "ShopperId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "ItemName" },
                values: new object[,]
                {
                    { 1, "item1" },
                    { 2, "item2" },
                    { 3, "item3" },
                    { 4, "item4" },
                    { 5, "item5" }
                });

            migrationBuilder.InsertData(
                table: "Shoppers",
                columns: new[] { "ShopperId", "ShopperName" },
                values: new object[,]
                {
                    { 1, "shopper1" },
                    { 2, "shopper2" },
                    { 3, "shopper3" },
                    { 4, "shopper4" },
                    { 5, "shopper5" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingLists",
                columns: new[] { "ShoppingListId", "ItemId", "ShopperId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 1, 3 },
                    { 3, 5, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingLists_ItemId",
                table: "ShoppingLists",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingLists_ShopperId",
                table: "ShoppingLists",
                column: "ShopperId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingLists");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Shoppers");
        }
    }
}
