using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Data.Configuration
{
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
        }
    }
}
