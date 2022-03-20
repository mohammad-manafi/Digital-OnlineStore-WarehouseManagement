using Warehouse.Warehouse.Tests.Unit;

namespace Warehouse.Domain
{
    public class Warehouse
    {
        public int Id { get; set; }

        public string productName { get; private set; }
        public string brand { get; private set; }
        public string model { get; private set; }
        public double unitPrice { get; private set; }

        public string product { get; private set; }
        public string brandName { get; private set; }
        public string modelName { get; private set; }
        public double price { get; private set; }
        public bool InStock { get; private set; }

        public Warehouse(string productName, string brand, string model, double unitPrice, string product, string brandName, string modelName, double price)
        {
            GuardAgainstInvalidProducts(productName, product);

            GuardAgainstInvalidUnitPrice(unitPrice);

            this.productName = productName;
            this.brand = brand;
            this.model = model;
            this.unitPrice = unitPrice;

            this.product = product;
            this.brandName = brandName;
            this.modelName = modelName;
            this.price = price;
        }

        private static void GuardAgainstInvalidProducts(string productname, string product)
        {
            if (string.IsNullOrEmpty(productname) && string.IsNullOrEmpty(product))
            {
                throw new ProductNullException();
            }
        }

        private static void GuardAgainstInvalidUnitPrice(double unitPrice)
        {
            if (unitPrice <= 0)
            {
                throw new InvalidUnitPriceException();
            }
        }
    }
}
