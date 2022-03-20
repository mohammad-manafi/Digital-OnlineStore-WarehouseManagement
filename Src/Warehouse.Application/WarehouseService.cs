using Warehouse.Application.Contract;
using Warehouse.Warehouse;

namespace Warehouse.Application
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepository _warehouseRepository;

        public WarehouseService(IWarehouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }

        public bool Define(DefineWarehouse command)
        {     
            var Warehouse = new Domain.Warehouse(
                command.productName,
                command.brand,
                command.model,
                command.unitPrice,
                command.product,
                command.brandName,
                command.modelName,
                command.price);

            _warehouseRepository.Create(Warehouse);

            return true;
        }
    }
}
