using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooShop.Infrastructure.Migrations
{
    public partial class ChangeUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ade948df-8bd7-460e-8f52-158c0d0cf7e3", "AQAAAAEAACcQAAAAEGnRvUMcc+cip8loAql6/4pXxxVUi6j+OUihJa2PPiN5LTg3QLqZcuJFkjU+CEEagw==", "e93a4a31-ed0e-4465-ad71-65f7750386f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c9a3f2b-d850-45bf-9031-be413bb53845", "AQAAAAEAACcQAAAAEKiaXtzoL0QBJaey+b7k5K8O3y2FkLnZA9mVaO4I+9n+F8lulpLVPYw4BHZTPmm6dw==", "e6827427-0372-48a2-8eb1-556a574bea2f" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://co.nice-cdn.com/upload/image/product/large/default/nailberry-lak-za-nokti-fuchsia-in-love-loxygene-15-ml-447434-bg.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.zoomagazinche.bg/goliam-akvarium-za-ribi-190-litra-ferplast-dubai-100.html");
        }
    }
}
