using FurnitureImporter.Entities.Customers;
using FurnitureImporter.Entities.Enum;

namespace FurnitureImporter.Ports.DataAccess
{
    public class CustumerRepository : ICustumerRepository
    {
        private IEnumerable<Customer> costumerTable = new List<Customer>() { 
            new Customer
            {
                Id = Guid.Parse("f4c1908f-6437-4965-b692-d07078b5d070"),
                FirstName = "User",
                LastName = "Usr",
                Email = "user@gmail.com",
                Address = "",
                IsCompany = false,
                RabateType = DiscountTypeEnum.SpecialOffer
            },
            new Customer
            {
                Id = Guid.Parse("58f80c7f-c250-4b3b-9426-1e2884455f29"),
                FirstName = "User2",
                LastName = "Usr2",
                Email = "user2@gmail.com",
                Address = "",
                IsCompany = true,
                RabateType = DiscountTypeEnum.VolumeDiscount
            },
        };

        public IEnumerable<Customer> GetAllCostumers()
        {
            return costumerTable.Where(c => c.Id != Guid.Empty);
        }

        public Customer GetCustomerById(Guid id)
        {
            return costumerTable.First(c => c.Id == id);
        }
    }
}
