using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooShop.Infrastructure.Migrations
{
    public partial class AddSeedDataMoreAccessCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccessoryCategories",
                table: "AccessoryCategories");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AccessoryCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccessoryCategories",
                table: "AccessoryCategories",
                columns: new[] { "Id", "CategoriesId", "AccessoriesId" });

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
                name: "IX_AccessoryCategories_CategoriesId",
                table: "AccessoryCategories",
                column: "CategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccessoryCategories",
                table: "AccessoryCategories");

            migrationBuilder.DropIndex(
                name: "IX_AccessoryCategories_CategoriesId",
                table: "AccessoryCategories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AccessoryCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccessoryCategories",
                table: "AccessoryCategories",
                columns: new[] { "CategoriesId", "AccessoriesId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97fb8f5a-1d4f-4dae-bbbf-0ad8183b2086", "AQAAAAEAACcQAAAAEPtqxtcxU0RgS30KEl2+kG8tSTbsMLoQWDKkKaD0JT2QWMDyyXY2RzMeAJQUKmCXFw==", "79651704-30d7-4418-b386-00e2c534ce6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1b6deb9-f8f2-4feb-8a5d-563e4bcffd2e", "AQAAAAEAACcQAAAAEPKAWNHvyC0HlwArhap+IiBzMM+0aI8YE+Vu68JvCGMwquBaSB53tkYchLBdHAK9pQ==", "a500b915-eb7d-43a6-b780-f19fb003a96e" });
        }
    }
}
