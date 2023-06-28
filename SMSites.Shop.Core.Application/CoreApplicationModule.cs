using Microsoft.Extensions.DependencyInjection;
using SMSites.Shop.Core.Domain;
using SMSites.Shop.Core.Domain.Services.Bus.Interfaces;
using System.Reflection;

namespace SMSites.Shop.Core.Application
{
    public static class CoreApplicationModule
    {
        // extension methods from IServiceCollection
        public static IServiceCollection AddCoreApplication<TInfrastructureBusService>(this IServiceCollection services, IList<Assembly> applicationAssemblies)
            where TInfrastructureBusService : class, IInfrastructureBusService
        {
            applicationAssemblies.Add(typeof(CoreApplicationModule).Assembly);
            services.AddCoreDomainModule<TInfrastructureBusService>(applicationAssemblies);
            return services;
        }
    }
}
