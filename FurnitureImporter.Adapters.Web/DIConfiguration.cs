using FurnitureImporter.Adapters.Web.Managers;
using FurnitureImporter.Ports.Web.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureImporter.Adapters.Web
{
    public static class DIConfiguration
    {
        public static void ConfigurePrimaryAdapters(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFurnitureImporterManager, FurnitureImporterManager>();
        }
    }
}
