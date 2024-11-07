namespace FurnitureImporter.Ports.Web.Models.Response
{
    public class Furniture
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
    }
}
