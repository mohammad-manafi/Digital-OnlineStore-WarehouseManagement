using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;
using System.Threading.Tasks;
using Warehouse.Application.Contract;
using Xunit;

namespace Warehouse.Presentation.Tests.Integration
{
    public class WarehouseControllerTests
    {
        private readonly RESTFulApiFactoryClient _client;

        public WarehouseControllerTests()
        {
            var factory = new WebApplicationFactory<Startup>();
            var httpClient = factory.CreateClient();
            _client = new RESTFulApiFactoryClient(httpClient);
        }

        [Fact]
        public async Task Should_DefineNewWarehouse()
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
           

            var result = await _client.PostContentAsync<DefineWarehouse, bool>("/api/Warehouse", command);

            result.Should().BeTrue();

        }
    }
}
