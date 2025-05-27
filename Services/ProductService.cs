using GroceryStockApi.Models;

namespace GroceryStockApi.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new();
        private int _nextId = 1;

        public void AddProduct(Product product)
        {
            if (product.Quantity < 0)
                throw new ArgumentException("Quantity must be non-negative.");

            product.Id = _nextId++;
            _products.Add(product);
        }

        public IEnumerable<Product> GetLowStockProducts()
        {
            return _products.Where(p => p.Quantity <= p.RestockThreshold);
        }
    }
}
