using FurnitureImporter.Domain.Contexts;
using FurnitureImporter.Domain.Contexts.DiscountStrategy;
using FurnitureImporter.Domain.Interfaces.DiscountStrategy;
using FurnitureImporterDomain.Contexts.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureImporter.Domain
{
    public static class DIConfiguration
    {
        public static void ConfigureDomain(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFurnitureImporterContext, FurnitureImporterContext>();

            //discount strategy
            serviceCollection.AddScoped<IBaseDiscountStrategy, BaseDiscountStrategy>();
            serviceCollection.AddScoped<IBaseDiscountStrategy, StandardDiscountStrategy>();
            serviceCollection.AddScoped<IBaseDiscountStrategy, VolumeDiscountStrategy>();
            serviceCollection.AddScoped<IBaseDiscountStrategy, SpecialOfferDiscountStrategy>();
        }
    }
}
