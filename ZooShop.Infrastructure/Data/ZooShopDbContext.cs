namespace ZooShop.Infrastructure.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using ZooShop.Infrastructure.Data.Models;

    public class ZooShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public ZooShopDbContext(DbContextOptions<ZooShopDbContext> options)
            : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Accessory> Accessories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Конфигуриране на Price
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            // Връзка между аксесоари и категории с NO ACTION при изтриване
            modelBuilder.Entity<Accessory>()
                .HasOne(a => a.Category)
                .WithMany(c => c.Accessories)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.NoAction); 

            // Връзка между продукти и категории с NO ACTION при изтриване
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction); 

            // Връзка между продукти и аксесоари с NO ACTION при изтриване
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Accessory)
                .WithMany() 
                .HasForeignKey(p => p.AccessoryId)
                .OnDelete(DeleteBehavior.NoAction); 


        }
    }

}
