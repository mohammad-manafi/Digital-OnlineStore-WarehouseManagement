using Warehouse.Domain;

namespace Warehouse.Warehouse.Tests.Unit
{
    public class WarehouseTestBuilder
    {
        private string _productName = "Mobile";
        private string _brand = "IPhone";
        private string _model = "Pro max 13";
        private double _unitPrice = 1100;

        private string _product = "Tablet";
        private string _brandName = "Samsung";
        private string _modelName = "Galaxy Tab S8";
        private double _price = 960;

        public WarehouseTestBuilder withProductName(string productName)
        {
            _productName = productName;
            return this;
        }

        public WarehouseTestBuilder withBrand(string brand)
        {
            _brand = brand;
            return this;
        }

        public WarehouseTestBuilder withModel(string model)
        {
            _model = model;
            return this;
        }

        public WarehouseTestBuilder withUnitPrice(double unitPrice)
        {
            _unitPrice = unitPrice;
            return this;
        }

        public WarehouseTestBuilder withProduct(string product)
        {
            _product = product;
            return this;
        }

        public WarehouseTestBuilder withBrandName(string brand)
        {
            _brandName = brand;
            return this;
        }

        public WarehouseTestBuilder withModelName(string model)
        {
            _modelName = model;
            return this;
        }

        public WarehouseTestBuilder withPrice(double Price)
        {
            _price = Price;
            return this;
        }

        public Domain.Warehouse Build()
        {
            return new Domain.Warehouse(_productName, _brand, _model, _unitPrice, _product, _brandName, _modelName, _price);
        }
    }
}
