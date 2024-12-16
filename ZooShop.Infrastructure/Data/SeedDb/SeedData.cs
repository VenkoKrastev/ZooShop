using Microsoft.AspNetCore.Identity;
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

        }

        //Users
        public IdentityUser AdminUser { get; set; }
        public IdentityUser GuestUser { get; set; }

        public Product Purina { get; set; }

        public Category Dog { get; set; }

        public Accessory Bed { get; set; }




        private void SeedAccessory()
        {
            Bed = new Accessory()
            {
                Id = 1,
                Name = "Bed",
                CategoryId = 1,

            };
        }

        private void SeedCategory()
        {
            Dog = new Category()
            {
                Id = 1,
                Name = "Dog"
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
