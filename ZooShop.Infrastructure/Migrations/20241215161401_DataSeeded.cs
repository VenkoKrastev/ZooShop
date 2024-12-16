using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooShop.Infrastructure.Migrations
{
    public partial class DataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 1, 0, "Bed" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "59ee1bb1-297d-4d52-8b19-bd77e3c70853", "IdentityUser", "guest@gmail.com", false, false, null, "GUEST@GMAIL.COM", "GUEST@GMAIL.COM", "AQAAAAEAACcQAAAAEDcQlR/dY1Yy/Rfu0T8UB8vkmZ4KeXOIooNm6WEs6NCkVrJn96h4OqV7yQfe1+MbOA==", null, false, "11a9d450-79d1-4cea-be32-b962a6afb7cc", false, "guest@gmail.com" },
                    { "c2f14bf7-ffdd-47a4-90b3-f2309486fae9", 0, "38df1331-f91d-4341-997f-4f36ccd8b479", "IdentityUser", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPJh/dVZ96MrrcJPFfg5NV2+/2uneA33iRTraSJrFwNtln7iIs/WaJvyBfVwbUlNrg==", null, false, "954ab2e1-257c-453b-a4a0-3c0d23d7956c", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Dog" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AccessoryId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[] { 1, 1, 1, "Кучешка храна Пюрина Мини Актив 800г с пилешко месо и ориз", "https://www.purina.bg/kucheta/hrana-za-kucheta/product-suha-pro-plan-puppy-healthy-start-sredni-porodi-pileshko", "Purina", 10.00m, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
