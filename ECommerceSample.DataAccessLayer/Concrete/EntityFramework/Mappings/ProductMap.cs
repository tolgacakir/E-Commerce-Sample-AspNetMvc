using ECommerceSample.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSample.DataAccessLayer.Concrete.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"Products", @"dbo");

            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Name).HasColumnName("Name");
            builder.Property(p => p.Description).HasColumnName("Description");
            builder.Property(p => p.CategoryId).HasColumnName("CategoryId");
            builder.Property(p => p.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(p => p.UnitsInStock).HasColumnName("UnitsInStock");
        }
    }
}
