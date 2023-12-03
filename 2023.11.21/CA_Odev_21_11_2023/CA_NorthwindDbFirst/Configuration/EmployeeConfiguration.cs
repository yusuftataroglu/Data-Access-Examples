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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(employee =>  employee.FirstName).HasMaxLength(10).IsRequired();
            builder.Property(employee => employee.LastName).HasMaxLength(20).IsRequired();
            builder.Property(employee => employee.Address).HasMaxLength(60);
            builder.Property(employee => employee.City).HasMaxLength(15);
            builder.Property(employee => employee.Title).HasMaxLength(30);

        }
    }
}
