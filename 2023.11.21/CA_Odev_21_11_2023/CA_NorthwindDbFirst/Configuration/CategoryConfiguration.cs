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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(cat => cat.CategoryName).HasMaxLength(15).IsRequired();
            builder.Property(cat => cat.Description).HasMaxLength(500);

            //Varsayılan veriler

            List<Category> categories = new List<Category> 
            {
                new Category
                {
                    Id=1,
                    CategoryName="Beverages",
                    Description="Soft drinks, coffees, teas, beers, and ales"
                }
            };
            builder.HasData(categories);
        }
    }
}
