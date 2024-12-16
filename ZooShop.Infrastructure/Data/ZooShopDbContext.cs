namespace ZooShop.Infrastructure.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection.Emit;
    using ZooShop.Infrastructure.Data.Models;
    using ZooShop.Infrastructure.Data.SeedDb;

    public class ZooShopDbContext : IdentityDbContext<IdentityUser>
    {
        public ZooShopDbContext(DbContextOptions<ZooShopDbContext> options)
            : base(options) { }

        public DbSet<Category>? Categories { get; set; } 
        public DbSet<Product>? Products { get; set; } 
        public DbSet<Order>? Orders { get; set; } 
        public DbSet<OrderItem>? OrderItems { get; set; } 
        public DbSet<Review>? Reviews { get; set; } 
        public DbSet<Accessory>? Accessories { get; set; }
        public DbSet<AccessoryCategory>? AccessoryCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new AccessoryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());

            builder.Entity<AccessoryCategory>()
            .HasKey(ac => new { ac.CategoriesId, ac.AccessoriesId });

            builder.Entity<AccessoryCategory>()
                .HasOne(ac => ac.Category)
                .WithMany(c => c.AccessoryCategories)
                .HasForeignKey(ac => ac.CategoriesId);

            builder.Entity<AccessoryCategory>()
                .HasOne(ac => ac.Accessory)
                .WithMany(a => a.AccessoryCategories)
                .HasForeignKey(ac => ac.AccessoriesId);


            base.OnModelCreating(builder);

        }
    }

}
