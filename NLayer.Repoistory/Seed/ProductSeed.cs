using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nlayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seed
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                Name = "Pencil 1",
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 2,
                Name = "Pencil 2",
                CategoryId = 1,
                Price = 200,
                Stock = 20,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 3,
                Name = "Pencil 3",
                CategoryId = 1,
                Price = 300,
                Stock = 25,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 4,
                Name = "Book 1",
                CategoryId = 2,
                Price = 400,
                Stock = 200,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 5,
                Name = "Book 2",
                CategoryId = 2,
                Price = 300,
                Stock = 200,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 6,
                Name = "Notebook 1",
                CategoryId = 3,
                Price = 150,
                Stock = 60,
                CreatedDate = DateTime.Now
            });
        }
    }
}
