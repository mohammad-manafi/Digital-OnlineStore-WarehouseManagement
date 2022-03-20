using NSubstitute;
using System;
using Warehouse.Application.Contract;
using Warehouse.Presentation.Controllers;
using Xunit;
using Xunit.Categories;

namespace Warehouse.Presentation.Tests.Unit
{
    public class WarehouseControllerTests
    {
        private readonly WarehouseController _Controller;
        private readonly IWarehouseService _warehouseService;

        public WarehouseControllerTests()
        {
            _warehouseService = Substitute.For<IWarehouseService>();
            _Controller = new WarehouseController(_warehouseService);
        }

        [Fact]
        [UnitTest]
        public void Should_CallDefineOnService()
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

            _Controller.Define(command);

            _warehouseService.ReceivedWithAnyArgs().Define(default);
        }
    }
}
