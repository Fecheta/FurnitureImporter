using FurnitureImporter.Ports.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureImporter.Adapters.DataAccess
{
    public static class DIConfiguration
    {
        public static void ConfigurateDataAcces(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFurnitureRepository, FurnitureRepository>();
            serviceCollection.AddScoped<ICustumerRepository, CustumerRepository>();
        }
    }
}
