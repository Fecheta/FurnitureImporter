using FurnitureImporter.Adapters.Web.DataMapper.ToResponse;
using FurnitureImporter.Ports.Web.Interfaces;
using FurnitureImporter.Ports.Web.Models.Response;
using FurnitureImporterDomain.Contexts.Interfaces;

namespace FurnitureImporter.Adapters.Web.Managers
{
    public class FurnitureImporterManager : IFurnitureImporterManager
    {
        private readonly IFurnitureImporterContext _context;
       
        public FurnitureImporterManager(IFurnitureImporterContext context) { 
            _context = context;
        }

        public IEnumerable<Customer> GetAllCustumers()
        {
           var result = _context.GetAllCostumers().ToModel();
           return result;
        }

        public IEnumerable<Furniture> GetAllFurnitures()
        {
            var result = _context.GetAllFurnitures().ToModel();
            return result;
        }

        public int GetNumber()
        {
            var result = _context.GetCountAll();
            return result;
        }

        public double GetDiscountePrice(Guid userId, Guid furnitureId)
        {
            var result = _context.GetDiscountePrice(userId, furnitureId);
            return result;
        }
    }
}
