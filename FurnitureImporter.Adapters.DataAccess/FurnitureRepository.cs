using FurnitureImporter.Entities.Furniture;
using FurnitureImporter.Ports.DataAccess;

namespace FurnitureImporter.Adapters.DataAccess
{
    public class FurnitureRepository : IFurnitureRepository
    {
        public List<Furniture> furnitureTable = new List<Furniture>
            {
                new Furniture
                {
                    Id = Guid.Parse("b14b537b-85e0-4b59-b674-ee0647ef491a"),
                    Name = "Name Test1",
                    Description = "Description",
                    Price = 22.22
                },
                new Furniture
                {
                    Id = Guid.Parse("a435aa30-3ea8-4407-a1ef-4b87c4dc29e4"),
                    Name = "Name2 Test2",
                    Description = "Description",
                    Price = 22.22
                },
                new Furniture
                {
                    Id = Guid.Parse("2026c185-63c2-423d-9486-a0cee416d126"),
                    Name = "Test3 Name",
                    Description = "Description",
                    Price = 22.22
                }
            };

        public IEnumerable<Furniture> GetAllFurnitures()
        {
            return furnitureTable.Where(f => f.Id != Guid.Empty).AsEnumerable();
        }

        public Furniture GetFurnitureById(Guid id)
        {
            return furnitureTable.First(f => f.Id == id);
        }
    }
}
