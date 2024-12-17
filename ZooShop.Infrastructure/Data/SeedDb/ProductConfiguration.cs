using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using ZooShop.Infrastructure.Data.Models;

namespace ZooShop.Infrastructure.Data.SeedDb
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            builder
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.Accessory)
                .WithMany(a => a.Products)
                .HasForeignKey(p => p.AccessoryId)
                .OnDelete(DeleteBehavior.Restrict);

            
            var data = new SeedData();

            builder.HasData(new Product[] { data.Purina, data.AquaElAquarium, data.FerplastMemorOne, data.Whiskas, data.FleaAndThickCollar});

        }
    }
}
