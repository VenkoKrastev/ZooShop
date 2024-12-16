using Microsoft.AspNetCore.Identity;
using System.IO;
using ZooShop.Infrastructure.Data.Models;

namespace ZooShop.Infrastructure.Data.SeedDb
{
    internal  class SeedData
    {
        public SeedData()
        {
            SeedUsers();
            SeedProduct();
            SeedCategory();
            SeedAccessory();
            SeedAccessoryCategory();

        }

       

        //Users
        public IdentityUser AdminUser { get; set; }
        public IdentityUser GuestUser { get; set; }

        public Product Purina { get; set; }
        public Product Whiskas { get;  set; }
        public Product FerplastMemorOne { get; set; }
        public Product FleaAndThickCollar { get;  set; }
        public Product AquaElAquarium { get; set; }

        public Category Dog { get; set; }
        public Category Cat { get; set; }
        public Category Fish { get; set; }
        public Category Bird { get; set; }
        public Category Rodents { get; set; }


        public Accessory Bed { get; set; }
        public Accessory Strap { get; set; }
        public Accessory Food { get; set; }
        public Accessory Aquarium { get; set; }
        public Accessory Cage { get; set; }

        public AccessoryCategory hrana { get; set; }


        private void SeedAccessoryCategory()
        {
            hrana = new AccessoryCategory()
            {
                CategoriesId = 1,
                AccessoriesId = 3,
            };
        }
        private void SeedAccessory()
        {
            Bed = new Accessory()
            {
                Id = 1,
                Name = "Bed"

            };
            Strap = new Accessory()
            {
                Id = 2,
                Name = "Strap",
            };
            Food = new Accessory()
            {
                Id = 3,
                Name = "Food"
            };
            Aquarium = new Accessory()
            {
                Id = 4,
                Name = "Aquarium"   
            };
            Cage = new Accessory()
            {
                Id = 5,
                Name = "Cage"
            };

        }

        private void SeedCategory()
        {
            Dog = new Category()
            {
                Id = 1,
                Name = "Dog"
            };
            Cat = new Category()
            {
                Id = 2,
                Name = "Cat"
            };
            Fish = new Category()
            {
                Id = 3,
                Name = "Fish"
            };
            Bird = new Category()
            {
                Id = 4,
                Name = "Bird"
            };
            Rodents = new Category()
            {
                Id = 5,
                Name = "Rodets"
            };
        }

        private void SeedProduct()
        {
            Purina = new Product()
            {
                Id = 1,
                Name = "Purina",
                Price = 10.00m,
                StockQuantity = 3,
                Description = "Кучешка храна Пюрина Мини Актив 800г с пилешко месо и ориз",
                ImageUrl = "https://www.purina.bg/kucheta/hrana-za-kucheta/product-suha-pro-plan-puppy-healthy-start-sredni-porodi-pileshko",
                CategoryId = 1,
                AccessoryId = 1
            };

            Whiskas = new Product()
            {
                Id = 2,
                Name = "Whiskas Pure Delight месни или птичи ястия 4 х 85 гр",
                Price = 4.20m,
                StockQuantity = 20,
                Description = "Обогатени с подбрани зеленчуци и масла , овкусени с билки и пресни подправки тези късчета месо имат превъзходен вкус, в който котката Ви ще се влюби.",
                ImageUrl = "https://zoocenter.bg/product/whiskas-pure-delight-mesni-ili-ptichi-yastiya-4-h-85-gr",
                CategoryId = 2,
                AccessoryId = 3
            };

            FerplastMemorOne = new Product()
            {
                Id = 3,
                Name = "Ferplast MEMOR-ONE",
                Price = 231.27m,
                StockQuantity = 5,
                Description = "Здрав диван за кучета с вътрешен матрак от мемори пяна. Насърчава благосъстоянието и комфорта на вашето животно. Осигурява оптимална подкрепа за вашия приятел",
                ImageUrl = "https://mypetshop.bg/ferplast-memor-one-medium-kucheshko-leglo-s-ortopedichen-matrak-ot-memori-pyana-64-x-52-x-h-165-sm-p1044198",
                CategoryId = 1,
                AccessoryId = 1
            };

            FleaAndThickCollar = new Product()
            {
                Id = 4,
                Name = "ПРОТИВОПАРАЗИТНИ КАИШКИ ЗА КОТЕ FLEA AND TICK COLLAR",
                Price = 6.70m,
                StockQuantity = 8,
                Description = "ПРОТИВОПАРАЗИТНА КАИШКА ЗА КОТЕ ЗА 8-МЕСЕЧНА ЗАЩИТА И ТРЕТИРАНЕ НА БЪЛХИ И КЪРЛЕЖИ ПРИ КУЧЕТА НА НАЙ-МАЛКО 7 СЕДМИЧНА ВЪЗРАСТ Инструкция за употреба: Поставете нашийникаоколо врата на домашния любимец, плъзнете края на нашийника при катараматаи го регулирайте да пасне. Оставете място около 4-5 смза разтеж на домашния любимец и допълнително регулирайте. Закопчайте на място и отрежете излишната дължина. При нормално състояние нашийника трябва да се сменя на всеки 8 месеца. При условия на силно заразяване, сменяйте нашийника по-често. Домашният любимецможе да се носи нашийника 24 часа на ден, докато се къпе или играе под дъжда.ВНИМАНИЕ: Дръжте нашийника далеч от деца. СЪСТАВ: Лимонов евкалипт- 60%, масло от линалое - 25%, масло от цитронела 10%, масло от лавандула - 5%.",
                ImageUrl = "https://farmavet.bg/produkt/%D0%BF%D1%80%D0%BE%D1%82%D0%B8%D0%B2%D0%BE%D0%BF%D0%B0%D1%80%D0%B0%D0%B7%D0%B8%D1%82%D0%BD%D0%B8-%D0%BA%D0%B0%D0%B8%D1%88%D0%BA%D0%B8-%D0%B7%D0%B0-%D0%BA%D0%BE%D1%82%D0%B5-flea-and-tick-collar/",
                CategoryId = 2,
                AccessoryId = 2
            };

            AquaElAquarium = new Product()
            {
                Id= 5,
                Name = "AquaEl Голям аквариум за риби 190 литра",
                Price = 750.3m,
                StockQuantity = 10,
                Description = "Перфектен за декорация на рестуранти, рецепции, офиси и за дома с изчистен и модерен дизайн. Предлагат се в 4 различни цвята и размери за перфектно съчетаване с вашето обзавеждане:",
                ImageUrl = "https://www.zoomagazinche.bg/goliam-akvarium-za-ribi-190-litra-ferplast-dubai-100.html",
                CategoryId = 3,
                AccessoryId = 4
            };
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AdminUser = new IdentityUser()
            {
                Id = "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM"
            };

            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "admin420");

            GuestUser = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@gmail.com",
                NormalizedUserName = "GUEST@GMAIL.COM",
                Email = "guest@gmail.com",
                NormalizedEmail = "GUEST@GMAIL.COM"

            };

            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "guest420");
        }
    }
}
