using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooShop.Infrastructure.Migrations
{
    public partial class SeedAccessCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
