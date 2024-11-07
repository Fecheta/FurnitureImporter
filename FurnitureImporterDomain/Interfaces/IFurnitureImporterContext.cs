using FurnitureImporter.Entities.Customers;
using FurnitureImporter.Entities.Furniture;

namespace FurnitureImporterDomain.Contexts.Interfaces
{
    public interface IFurnitureImporterContext
    {
        int GetCountAll();
        IEnumerable<Furniture> GetAllFurnitures();
        IEnumerable<Customer> GetAllCostumers();
        double GetDiscountePrice(Guid userId, Guid furnitureId);
    }
}
