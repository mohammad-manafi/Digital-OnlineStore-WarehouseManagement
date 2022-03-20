using Microsoft.EntityFrameworkCore;
using System;
using Warehouse.Domain;

namespace Warehouse.Infrastructure
{
    public class WarehouseContext : DbContext
    {
        public DbSet<Domain.Warehouse> wharehouses { get; set; }
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base (options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WarehouseMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
