using Entity = FurnitureImporter.Entities;
using Model = FurnitureImporter.Ports.Web.Models.Response;

namespace FurnitureImporter.Adapters.Web.DataMapper.ToResponse
{
    public static class DataMapper
    {
        public static IEnumerable<Model.Furniture> ToModel(this IEnumerable<Entity.Furniture.Furniture> models)
            => models?.Select(m => m.ToModel());

        public static Model.Furniture ToModel(this Entity.Furniture.Furniture model)
        {
            if (model == null) { return null; }

            return new Model.Furniture
            {
                Id = model.Id,
                Name = model.Name, 
                Description = model.Description,
                Price = model.Price,
            };
        }

       public static IEnumerable<Model.Customer> ToModel(this IEnumerable<Entity.Customers.Customer> models)
            => models?.Select(m => m.ToModel());

        public static Model.Customer ToModel(this Entity.Customers.Customer model)
        {
            if (model == null) { return null; }

            return new Model.Customer
            {
                Id= model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Address = model.Address,
                IsCompany = model.IsCompany,
            };
        }
    }
}
