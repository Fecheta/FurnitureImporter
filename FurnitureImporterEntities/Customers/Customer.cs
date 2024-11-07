using FurnitureImporter.Entities.Enum;

namespace FurnitureImporter.Entities.Customers
{
    public class Customer: IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsCompany { get; set; }
        public DiscountTypeEnum RabateType { get; set; }
    }
}
