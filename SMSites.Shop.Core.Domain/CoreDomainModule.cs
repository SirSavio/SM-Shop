using Microsoft.Extensions.DependencyInjection;
using SMSites.Shop.Core.Domain.Services.Bus;
using SMSites.Shop.Core.Domain.Services.Bus.Interfaces;
using SMSites.Shop.Core.Domain.Services.DomainNotifications;
using System.Reflection;

namespace SMSites.Shop.Core.Domain
{
    public static class CoreDomainModule
    {
        public static IServiceCollection AddCoreDomainModule<TInfrastructureBusService>(this IServiceCollection services, IList<Assembly> applicationAssemblies)
            where TInfrastructureBusService : class, IInfrastructureBusService
        {
            services.AddMediatR(cfg =>
            {
                foreach (var assembly in applicationAssemblies)
                    cfg.RegisterServicesFromAssembly(assembly);

                cfg.RegisterServicesFromAssembly(typeof(CoreDomainModule).Assembly);
            });

            services.AddScoped<DomainNotificationService>();
            services.AddScoped<IInfrastructureBusService, TInfrastructureBusService>();
            services.AddScoped<BusService>();

            return services;
        }
    }
}
