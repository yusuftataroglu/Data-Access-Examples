using CA_NorthwindDbFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindDbFirst.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(product => product.ProductName).HasMaxLength(40).IsRequired();

            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id=1,
                    CategoryId=1,
                    SupplierId=1,
                    ProductName="Chef Anton's Gumbo Mix",
                    UnitPrice=21.3500M,
                    UnitsInStock=10
                }
            };

            builder.HasData(products);
        }
    }
}
