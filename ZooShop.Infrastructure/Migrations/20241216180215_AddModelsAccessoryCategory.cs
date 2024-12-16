using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooShop.Infrastructure.Migrations
{
    public partial class AddModelsAccessoryCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessoryId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccessoryCategories",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    AccessoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessoryCategories", x => new { x.CategoriesId, x.AccessoriesId });
                    table.ForeignKey(
                        name: "FK_AccessoryCategories_Accessories_AccessoriesId",
                        column: x => x.AccessoriesId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessoryCategories_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99c22cab-710a-490e-82d7-0e00750cfea6", "AQAAAAEAACcQAAAAEDfBYqZw6u3esy5vq/opnti9vJMODmuferfm/kGpkiDW5BVzYT6cTl/m/xe216nj7Q==", "acbaece3-8365-49be-b942-af18439f04e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ebb1b48-ea2f-405a-8519-98bddfd0b75c", "AQAAAAEAACcQAAAAEAl9LxxpKQNcZLufe/h6Aqi0xcpXgQw0MJMnGgz9eGfH/cJ7AsiFXo/cf2uwXbVc8A==", "a7fa3235-9175-4752-991d-e8897885d5d9" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AccessoryId1",
                table: "Products",
                column: "AccessoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccessoryCategories_AccessoriesId",
                table: "AccessoryCategories",
                column: "AccessoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Accessories_AccessoryId1",
                table: "Products",
                column: "AccessoryId1",
                principalTable: "Accessories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Accessories_AccessoryId1",
                table: "Products");

            migrationBuilder.DropTable(
                name: "AccessoryCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_AccessoryId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AccessoryId1",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cba804c4-320f-45f1-9ccc-b45999c87ec3", "AQAAAAEAACcQAAAAELKNWsuAiJv7/94NqFqGa+f/Lefk4mIjjF5ulx92j/etUFGLKOhfKHGkcgvkGf+rnA==", "1849630e-5e4b-48f4-8d3b-043bb361511f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "241a6b86-c30a-402d-a958-62be322f42a5", "AQAAAAEAACcQAAAAEGQkZJkcgnuaSMHBVcdWGdEmYfdGY5g6nOUsESVvau723JWP/iWXfTCRtJPix7WlRA==", "dc946b23-21d2-451c-b858-cd7d4551f81e" });
        }
    }
}
