using FurnitureImporter.Entities.Enum;
using FurnitureImporter.Ports.DataAccess;

namespace FurnitureImporter.Domain.Contexts.DiscountStrategy
{
    public class StandardDiscountStrategy : BaseDiscountStrategy
    {
        public override DiscountTypeEnum DiscountType => DiscountTypeEnum.StandardRebate;

        private readonly IFurnitureRepository _furnitureRepository;

        public StandardDiscountStrategy(IFurnitureRepository furnitureRepository)
        {
            _furnitureRepository = furnitureRepository;
        }

        public override double GetDiscountedPrice(Guid furnitureId)
        {
            var furniture = _furnitureRepository.GetFurnitureById(furnitureId);

            return furniture.Price * 0.9;
        }
    }
}
