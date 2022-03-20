using FluentAssertions;
using System;
using Warehouse.Domain;
using Xunit;
using Xunit.Categories;

namespace Warehouse.Warehouse.Tests.Unit
{
    public class WarehouseTests
    {
        private readonly WarehouseTestBuilder _builder;

        public WarehouseTests()
        {
            _builder = new WarehouseTestBuilder();
        }

        [Fact]
        [UnitTest]
        public void Should_ConstructWharehouseProperly()
        {
            const string productName = "Laptop";
            const string brand = "Apple";
            const string model = "macbook pro";
            const double unitPrice = 1500;

            const string product = "Mobile";
            const string brandName = "Samsung";
            const string modelName = "Galaxy S21 Ultra";
            const double price = 1000;

            var wharehouse = _builder
                .withProductName(productName)
                .withBrand(brand)
                .withModel(model)
                .withUnitPrice(unitPrice)
                .withProduct(product)
                .withBrandName(brandName)
                .withModelName(modelName)
                .withPrice(price)
                .Build();

            wharehouse.productName.Should().Be(productName);
            wharehouse.brand.Should().Be(brand);
            wharehouse.model.Should().Be(model);
            wharehouse.unitPrice.Should().Be(unitPrice);
            wharehouse.product.Should().Be(product);
            wharehouse.brandName.Should().Be(brandName);
            wharehouse.modelName.Should().Be(modelName);
            wharehouse.price.Should().Be(price);
            wharehouse.InStock.Should().BeFalse();
        }

        [Theory]
        [UnitTest]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowExceptionProductNullException_WhenProductIs(string nullorEmpty)
        {
            Action ctor = () => _builder
            .withProductName(nullorEmpty)
            .withProduct(nullorEmpty)
            .Build();

            ctor.Should().ThrowExactly<ProductNullException>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Should_ThrowInvalidUnitPriceException_WhenUnitPriceIs(double zeroOrLess)
        {
            Action ctor = () => _builder
                .withUnitPrice(zeroOrLess)
                .Build();

            ctor.Should().ThrowExactly<InvalidUnitPriceException>();
        }
    }
}
