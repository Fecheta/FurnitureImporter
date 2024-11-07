using FurnitureImporter.Entities.Enum;
using FurnitureImporter.Ports.DataAccess;

namespace FurnitureImporter.Domain.Contexts.DiscountStrategy
{
    public class VolumeDiscountStrategy : BaseDiscountStrategy
    {
        public override DiscountTypeEnum DiscountType => DiscountTypeEnum.VolumeDiscount;

        private readonly IFurnitureRepository _furnitureRepository;

        public VolumeDiscountStrategy(IFurnitureRepository furnitureRepository)
        {
            _furnitureRepository = furnitureRepository;
        }

        public override double GetDiscountedPrice(Guid furnitureId)
        {
            var furniture = _furnitureRepository.GetFurnitureById(furnitureId);

            return furniture.Price * 0.2;
        }
    }
}
