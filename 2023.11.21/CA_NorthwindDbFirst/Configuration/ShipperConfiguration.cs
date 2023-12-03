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
    public class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.Property(shipper=>shipper.CompanyName).HasMaxLength(40).IsRequired();
            builder.Property(shipper=>shipper.PhoneNumber).HasMaxLength(24);
        }
    }
}
