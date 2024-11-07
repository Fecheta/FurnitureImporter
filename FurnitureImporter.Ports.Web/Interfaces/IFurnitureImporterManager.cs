using FurnitureImporter.Ports.Web.Models.Response;

namespace FurnitureImporter.Ports.Web.Interfaces
{
    public interface IFurnitureImporterManager
    {
        IEnumerable<Furniture> GetAllFurnitures();
        IEnumerable<Customer> GetAllCustumers();
        double GetDiscountePrice(Guid userId, Guid furnitureId);
        int GetNumber();
    }
}
