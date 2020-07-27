using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Data.Configurations
{
    public class ProductConfiguration:IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
            builder.Property(t => t.CategoryId).IsRequired();
            builder.HasIndex(p => new { p.Title, p.CategoryId }).IsUnique(true);
        }
    }
}
