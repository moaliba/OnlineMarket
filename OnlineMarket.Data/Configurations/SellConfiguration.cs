using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Data.Configurations
{
    public class SellConfiguration: IEntityTypeConfiguration<Sell>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sell> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.ProductId).IsRequired();
            builder.Property(t => t.Amount).IsRequired();
            builder.Property(t => t.SellDate).IsRequired();
            builder.Property(t => t.FactorNumber).IsRequired();
            builder.Property(t => t.Price).IsRequired();
            builder.Property(t => t.CustomerName).IsRequired();
        }
    }
}
