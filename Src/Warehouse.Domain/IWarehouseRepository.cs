using System;
using Warehouse.Domain;

namespace Warehouse.Warehouse
{
    public interface IWarehouseRepository
    {
        void Create(Domain.Warehouse entity);
        void Save();
    }
}
