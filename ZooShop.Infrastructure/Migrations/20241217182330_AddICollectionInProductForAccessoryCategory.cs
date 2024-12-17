using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooShop.Infrastructure.Migrations
{
    public partial class AddICollectionInProductForAccessoryCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "AccessoryCategories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0f635e7-4f2e-4aa9-ac89-9480ae6a31bb", "AQAAAAEAACcQAAAAEGk1jX+tTNqLyiYE0JQby2d9JMAgCzdi0AGN48s33kMJD8iODoeb6pCzA39UyBNe0g==", "34815c02-63c6-46a3-bd45-e544401063c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fe099c0-22cf-43b4-ad2d-c1a2a6332fd4", "AQAAAAEAACcQAAAAEMy9pQ0DgGbgZEJqoEkRx8RhXk6LsAGXU3/B/ISY1iQSrMJta4n/c6KTcsSdA7I7vw==", "56de4bee-a7b6-4033-ae94-14f9e8370e8c" });

            migrationBuilder.CreateIndex(
                name: "IX_AccessoryCategories_ProductId",
                table: "AccessoryCategories",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccessoryCategories_Products_ProductId",
                table: "AccessoryCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccessoryCategories_Products_ProductId",
                table: "AccessoryCategories");

            migrationBuilder.DropIndex(
                name: "IX_AccessoryCategories_ProductId",
                table: "AccessoryCategories");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "AccessoryCategories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e641ff0e-31cd-412e-8468-4f8490e65e41", "AQAAAAEAACcQAAAAEBWvHU4z49SVh1FOTOokSZRMEnh7zIvr+GSEssspYPiiN8pcwNt8hAVisETNLozMWA==", "3e610501-68a8-4333-82b8-32bc78ff46ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed47b3d0-667e-4d13-8adf-5727cd4e6867", "AQAAAAEAACcQAAAAEFnYegb3YwB1andnmvkJV/WFyCa5qsLJ33WVpBrdRP43kzN9rZQyS4S+AO9lPCqZGQ==", "9b3e41f9-da14-4e1f-82f1-b3f2d41c6ea8" });
        }
    }
}
