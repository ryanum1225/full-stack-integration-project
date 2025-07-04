using InventoryHub.Shared.Models;
using System.Text.Json;

namespace ServerApp.Services
{
    public class ProductService
    {
        /*Categories*/
        private static readonly Dictionary<int, string> Categories = new Dictionary<int, string>
            {
                {101, "Electronics"},
                {102, "Accessories"}
            };

        /*Product Catalog*/
        private static readonly List<Product> products = new List<Product>()
        {
            new(1, "Laptop", 1200.00, 25, "Electronics"),
            new(2, "Headphones", 50.00, 100, "Accessories")
        };

        public static IReadOnlyList<Product> GetProducts()
        {
            return products;
        }
    }
}