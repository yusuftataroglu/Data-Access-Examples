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
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(supplier => supplier.CompanyName).HasMaxLength(40).IsRequired();
            builder.Property(supplier => supplier.ContactName).HasMaxLength(30);
            builder.Property(supplier => supplier.ContactTitle).HasMaxLength(30);

            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier
                {
                    Id = 1,
                    CompanyName="Exotic Liquids",
                    ContactName="Charlotte Cooper",
                    ContactTitle="Purchasing Manager"
                }
            };

            builder.HasData(suppliers);

        }
    }
}
