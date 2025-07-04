using System.Reflection;
using InventoryHub.Shared.Models;

namespace InventoryHub.Shared.Models
{
    public class Product
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public double Price { get; init; }
        public int Stock { get; init; }
        public string Category { get; init; }

        public Product(int id, string name, double price, int stock, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            Category = category;
        }
    }

}