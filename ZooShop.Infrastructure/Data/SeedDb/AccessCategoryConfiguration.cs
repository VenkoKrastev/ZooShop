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
    internal class AccessCategoryConfiguration : IEntityTypeConfiguration<AccessoryCategory>
    {
        public void Configure(EntityTypeBuilder<AccessoryCategory> builder)
        {
            var data = new SeedData();

            builder.HasData(new AccessoryCategory[] { data.hrana, data.Leglo, data.Kletka });
        }
    }
}
