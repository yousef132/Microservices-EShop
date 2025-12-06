namespace Catalog.API.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Categories { get; set; } = new();
        public decimal Price { get; set; }
        public string ImageFile { get; set; } = default!;

    }
}
