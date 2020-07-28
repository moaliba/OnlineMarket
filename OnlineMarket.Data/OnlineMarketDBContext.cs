using Microsoft.EntityFrameworkCore;
using OnlineMarket.Data.Configuration;
using OnlineMarket.Data.Configurations;
using OnlineMarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMarket.Data
{
    public class OnlineMarketDBContext: DbContext
    {
        public OnlineMarketDBContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sell> Sells { get; set; }

        public DbSet<WarehouseEntrance> WarehouseEntrances { get; set; }

        public DbSet<ExpenceDocument> ExpenceDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new SellConfiguration());
            builder.ApplyConfiguration(new WarehouseEntranceConfiguration());
            builder.ApplyConfiguration(new ExpenceDocumentConfiguration());
        }


    }
}
