using FurnitureImporter.Domain.Interfaces.DiscountStrategy;
using FurnitureImporter.Entities.Enum;

namespace FurnitureImporter.Domain.Contexts.DiscountStrategy
{
    public class BaseDiscountStrategy : IBaseDiscountStrategy
    {
        public virtual DiscountTypeEnum DiscountType => DiscountTypeEnum.Base;

        public virtual double GetDiscountedPrice(Guid furnitureId)
        {
            return new Random().NextDouble();
        }
    }
}
