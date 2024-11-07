using FurnitureImporter.Domain.Contexts.DiscountStrategy;
using FurnitureImporter.Domain.Interfaces.DiscountStrategy;
using FurnitureImporter.Entities.Customers;
using FurnitureImporter.Entities.Furniture;
using FurnitureImporter.Ports.DataAccess;
using FurnitureImporterDomain.Contexts.Interfaces;

namespace FurnitureImporter.Domain.Contexts
{
    public class FurnitureImporterContext : IFurnitureImporterContext
    {
        private readonly IFurnitureRepository _furnitureRepository;
        private readonly ICustumerRepository _custumerRepository;
        private readonly IEnumerable<IBaseDiscountStrategy> _discountStrategies;


        public FurnitureImporterContext(IFurnitureRepository furnitureRepository,
            ICustumerRepository costumerRepository,
            IEnumerable<IBaseDiscountStrategy> discountStrategies) { 
            _furnitureRepository = furnitureRepository;
            _custumerRepository = costumerRepository;
            _discountStrategies = discountStrategies;
        }

        public IEnumerable<Furniture> GetAllFurnitures()
        {
            var result = _furnitureRepository.GetAllFurnitures();
            return result;
        }

        public IEnumerable<Customer> GetAllCostumers()
        {
            var result = _custumerRepository.GetAllCostumers();
            return result;
        }

        public double GetDiscountePrice(Guid userId, Guid furnitureId) 
        {
            var custumer = _custumerRepository.GetCustomerById(userId);

            var discountStrategy = _discountStrategies.First(s => s.DiscountType.ToString() == custumer.RabateType.ToString());
            discountStrategy = discountStrategy ?? new BaseDiscountStrategy();

            return discountStrategy.GetDiscountedPrice(furnitureId);
        }

        public int GetCountAll()
        {
            var res = new Random().Next();
            return res;
        }
    }
}
