using System;
using Warehouse.Domain;
using Warehouse.Warehouse;

namespace Warehouse.Infrastructure
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly WarehouseContext _warehouseContext;

        public WarehouseRepository(WarehouseContext warehouseContext)
        {
            _warehouseContext = warehouseContext;
        }

        public void Create(Domain.Warehouse entity)
        {
            _warehouseContext.wharehouses.Add(entity);

            Save();
        }

        public void Save()
        {
            _warehouseContext.SaveChanges();
        }
    }
}
