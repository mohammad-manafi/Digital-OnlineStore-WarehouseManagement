using FluentAssertions;
using NSubstitute;
using Warehouse.Application;
using Warehouse.Application.Contract;
using Warehouse.Warehouse;
using Xunit;


namespace WarehouseApplication.Tests.Unit
{
    public class WarehouseServiceTests
    {
        private readonly WarehouseService _warehouseService;
        private readonly IWarehouseRepository _WarehouseRepository;
        public WarehouseServiceTests()
        {
            _WarehouseRepository = Substitute.For<IWarehouseRepository>();
            _warehouseService = new WarehouseService(_WarehouseRepository);

        }

        [Fact]
        public void Should_ReturnTrue_WhenWarehouseDefined()
        {
            var command = new DefineWarehouse {
                productName = "Iphone",
                brand = "Apple",
                model = "Pro max 13",
                unitPrice = 1100,

                product = "Tablet",
                brandName = "Samsung",
                modelName = "Galaxy Tab S8",
                price = 960
            };

            var result = _warehouseService.Define(command);

            result.Should().BeTrue();
        }
        [Fact]
        public void Should_DefineNewWarehouse()
        {
            var command = new DefineWarehouse
            {
                productName = "Iphone",
                brand = "Apple",
                model = "Pro max 13",
                unitPrice = 1100,

                product = "Tablet",
                brandName = "Samsung",
                modelName = "Galaxy Tab S8",
                price = 960
            };

            _warehouseService.Define(command);
            _WarehouseRepository.ReceivedWithAnyArgs().Create(default);


        }
    }
}
