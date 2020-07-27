using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Data.Configurations
{
    public class WarehouseEntranceConfiguration:IEntityTypeConfiguration<WarehouseEntrance>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WarehouseEntrance> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.ProductId).IsRequired();
            builder.Property(t => t.Amount).IsRequired();
            builder.Property(t => t.EntranceDate).IsRequired();
            builder.Property(t => t.FactorNumber).IsRequired();
        }
    }
}
