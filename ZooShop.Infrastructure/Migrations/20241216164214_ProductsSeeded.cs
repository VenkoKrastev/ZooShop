using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooShop.Infrastructure.Migrations
{
    public partial class ProductsSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Accessories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "The Name of product category",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldComment: "The Name of product category");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Accessories",
                type: "int",
                nullable: false,
                comment: "The current Accessory's Identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The current Category's Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Strap" },
                    { 3, "Food" },
                    { 4, "Aquarium" },
                    { 5, "Cage" }
                });

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Cat" },
                    { 3, "Fish" },
                    { 4, "Bird" },
                    { 5, "Rodets" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AccessoryId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[] { 3, 1, 1, "Здрав диван за кучета с вътрешен матрак от мемори пяна. Насърчава благосъстоянието и комфорта на вашето животно. Осигурява оптимална подкрепа за вашия приятел", "https://mypetshop.bg/ferplast-memor-one-medium-kucheshko-leglo-s-ortopedichen-matrak-ot-memori-pyana-64-x-52-x-h-165-sm-p1044198", "Ferplast MEMOR-ONE", 231.27m, 5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AccessoryId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[] { 2, 3, 2, "Обогатени с подбрани зеленчуци и масла , овкусени с билки и пресни подправки тези късчета месо имат превъзходен вкус, в който котката Ви ще се влюби.", "https://zoocenter.bg/product/whiskas-pure-delight-mesni-ili-ptichi-yastiya-4-h-85-gr", "Whiskas Pure Delight месни или птичи ястия 4 х 85 гр", 4.20m, 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AccessoryId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[] { 4, 2, 2, "ПРОТИВОПАРАЗИТНА КАИШКА ЗА КОТЕ ЗА 8-МЕСЕЧНА ЗАЩИТА И ТРЕТИРАНЕ НА БЪЛХИ И КЪРЛЕЖИ ПРИ КУЧЕТА НА НАЙ-МАЛКО 7 СЕДМИЧНА ВЪЗРАСТ Инструкция за употреба: Поставете нашийникаоколо врата на домашния любимец, плъзнете края на нашийника при катараматаи го регулирайте да пасне. Оставете място около 4-5 смза разтеж на домашния любимец и допълнително регулирайте. Закопчайте на място и отрежете излишната дължина. При нормално състояние нашийника трябва да се сменя на всеки 8 месеца. При условия на силно заразяване, сменяйте нашийника по-често. Домашният любимецможе да се носи нашийника 24 часа на ден, докато се къпе или играе под дъжда.ВНИМАНИЕ: Дръжте нашийника далеч от деца. СЪСТАВ: Лимонов евкалипт- 60%, масло от линалое - 25%, масло от цитронела 10%, масло от лавандула - 5%.", "https://farmavet.bg/produkt/%D0%BF%D1%80%D0%BE%D1%82%D0%B8%D0%B2%D0%BE%D0%BF%D0%B0%D1%80%D0%B0%D0%B7%D0%B8%D1%82%D0%BD%D0%B8-%D0%BA%D0%B0%D0%B8%D1%88%D0%BA%D0%B8-%D0%B7%D0%B0-%D0%BA%D0%BE%D1%82%D0%B5-flea-and-tick-collar/", "ПРОТИВОПАРАЗИТНИ КАИШКИ ЗА КОТЕ FLEA AND TICK COLLAR", 6.70m, 8 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AccessoryId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[] { 5, 4, 3, "Перфектен за декорация на рестуранти, рецепции, офиси и за дома с изчистен и модерен дизайн. Предлагат се в 4 различни цвята и размери за перфектно съчетаване с вашето обзавеждане:", "https://www.zoomagazinche.bg/goliam-akvarium-za-ribi-190-litra-ferplast-dubai-100.html", "AquaEl Голям аквариум за риби 190 литра", 750.3m, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

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
                table: "Accessories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Accessories",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                comment: "The Name of product category",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "The Name of product category");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Accessories",
                type: "int",
                nullable: false,
                comment: "The current Category's Identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The current Accessory's Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59ee1bb1-297d-4d52-8b19-bd77e3c70853", "AQAAAAEAACcQAAAAEDcQlR/dY1Yy/Rfu0T8UB8vkmZ4KeXOIooNm6WEs6NCkVrJn96h4OqV7yQfe1+MbOA==", "11a9d450-79d1-4cea-be32-b962a6afb7cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38df1331-f91d-4341-997f-4f36ccd8b479", "AQAAAAEAACcQAAAAEPJh/dVZ96MrrcJPFfg5NV2+/2uneA33iRTraSJrFwNtln7iIs/WaJvyBfVwbUlNrg==", "954ab2e1-257c-453b-a4a0-3c0d23d7956c" });

            
        }
    }
}
