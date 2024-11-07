using FurnitureImporter.Entities.Customers;

namespace FurnitureImporter.Ports.DataAccess
{
    public interface ICustumerRepository
    {
        Customer GetCustomerById(Guid id);
        IEnumerable<Customer> GetAllCostumers();
    }
}
