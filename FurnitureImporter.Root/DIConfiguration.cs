using FurnitureImporter.Adapters.DataAccess;
using FurnitureImporter.Adapters.Web;
using FurnitureImporter.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureImporter.Root
{
    public static class DIConfiguration
    {
        public static void ConfigureFurnitureImporterModule(this IServiceCollection service)
        {
            service.ConfigureDomain();
            service.ConfigurePrimaryAdapters();
            service.ConfigurateDataAcces();
        }
    }
}
