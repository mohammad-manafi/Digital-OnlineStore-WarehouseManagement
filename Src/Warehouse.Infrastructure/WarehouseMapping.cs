using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Warehouse.Domain;

namespace Warehouse.Infrastructure
{

    class WarehouseMapping : IEntityTypeConfiguration<Domain.Warehouse>
    {
        public void Configure(EntityTypeBuilder<Domain.Warehouse> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
