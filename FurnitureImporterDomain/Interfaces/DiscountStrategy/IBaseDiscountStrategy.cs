using FurnitureImporter.Entities.Enum;

namespace FurnitureImporter.Domain.Interfaces.DiscountStrategy
{
    public interface IBaseDiscountStrategy
    {
        DiscountTypeEnum DiscountType { get; }
        double GetDiscountedPrice(Guid furnitureId);
    }
}
