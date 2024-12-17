using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooShop.Infrastructure.Migrations
{
    public partial class SeedDataAccessCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Accessories_AccessoryId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AccessoryId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AccessoryId1",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AccessoryCategories",
                columns: new[] { "AccessoriesId", "CategoriesId", "Id" },
                values: new object[,]
                {
                    { 3, 1, 1 },
                    { 1, 2, 2 },
                    { 5, 4, 4 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccessoryCategories",
                keyColumns: new[] { "AccessoriesId", "CategoriesId", "Id" },
                keyValues: new object[] { 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "AccessoryCategories",
                keyColumns: new[] { "AccessoriesId", "CategoriesId", "Id" },
                keyValues: new object[] { 1, 2, 2 });

            migrationBuilder.DeleteData(
                table: "AccessoryCategories",
                keyColumns: new[] { "AccessoriesId", "CategoriesId", "Id" },
                keyValues: new object[] { 5, 4, 4 });

            migrationBuilder.AddColumn<int>(
                name: "AccessoryId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0b706a6-ca3c-4487-8d6b-c14fc8203a53", "AQAAAAEAACcQAAAAEK4mbrrQF0M0AgY9P9nNliFHqGeajFJRDFjAdw0G+1dsbmnkzDSi+X+2x6vTDFk5zQ==", "48725ba2-9735-4b54-9bc8-24185f80dc05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2650d1b0-6167-4d16-9382-786843769355", "AQAAAAEAACcQAAAAENrFsAEiYJbprUKUo4pg1xdlqFCCeLYSfX80sI5qIxbBrG/ZafmbdE/h12ZgWohiwQ==", "b297c182-34fc-4ff1-995a-34b6a1ce13f1" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AccessoryId1",
                table: "Products",
                column: "AccessoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Accessories_AccessoryId1",
                table: "Products",
                column: "AccessoryId1",
                principalTable: "Accessories",
                principalColumn: "Id");
        }
    }
}
