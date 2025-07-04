namespace InventoryHub.Shared.Models
{
    public class Category
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}