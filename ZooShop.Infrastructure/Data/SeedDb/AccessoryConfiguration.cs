using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShop.Infrastructure.Data.Models;

namespace ZooShop.Infrastructure.Data.SeedDb
{
    internal class AccessoryConfiguration : IEntityTypeConfiguration<Accessory>
    {
        public void Configure(EntityTypeBuilder<Accessory> builder)
        {
            var data = new SeedData();

            builder.HasData(new Accessory[] {data.Bed, data.Aquarium, data.Strap, data.Cage, data.Food});
        }
    }
}
