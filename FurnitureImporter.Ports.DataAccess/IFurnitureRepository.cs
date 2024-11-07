using FurnitureImporter.Entities.Furniture;

namespace FurnitureImporter.Ports.DataAccess
{
    public interface IFurnitureRepository
    {
        IEnumerable<Furniture> GetAllFurnitures();
        Furniture GetFurnitureById(Guid id);
    }
}
