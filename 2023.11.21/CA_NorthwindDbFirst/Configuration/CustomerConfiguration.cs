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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(customer=> customer.CompanyName).HasMaxLength(40).IsRequired();
            builder.Property(customer=> customer.ContactName).HasMaxLength(30);
            builder.Property(customer=> customer.ContactTitle).HasMaxLength(30);
            builder.Property(customer=> customer.Address).HasMaxLength(60);
        }
    }
}
