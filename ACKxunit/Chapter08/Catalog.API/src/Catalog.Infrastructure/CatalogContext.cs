using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure
{
    public class CatalogContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "catalog";
        public DbSet<Item> Items { get; set; }

        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            var ItemEntity = modelBuilder.Entity<Item>();
            ItemEntity.HasKey(item => item.Id);
            
        }
        */
    }
}
