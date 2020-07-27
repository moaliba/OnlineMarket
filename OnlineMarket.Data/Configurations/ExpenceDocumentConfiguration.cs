using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Data.Configurations
{
    public class ExpenceDocumentConfiguration:IEntityTypeConfiguration<ExpenceDocument>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ExpenceDocument> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.DocumentNumber).IsRequired();
            builder.Property(t => t.RegisterDate).IsRequired();
            builder.Property(t => t.FactorNumber).IsRequired();
            builder.Property(t => t.Price).IsRequired();
        }
    }
}
