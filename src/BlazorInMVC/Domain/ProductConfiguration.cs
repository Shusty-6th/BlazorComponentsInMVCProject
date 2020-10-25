using BlazorInMVC.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorInMVC.Domain
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
                new Product { Id = 1, Name = "Bike", Size = 52 },
                new Product { Id = 2, Name = "Ball", Size = 8 },
                new Product { Id = 3, Name = "Glove", Size = 34 },
                new Product { Id = 4, Name = "Ice skates", Size = 39 }
            );
        }
    }
}
