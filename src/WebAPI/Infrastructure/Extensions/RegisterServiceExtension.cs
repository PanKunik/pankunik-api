using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace WebAPI.Infrastructure.Extensions
{
    public static class RegisterServiceExtension
    {
        public static void RegisterServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var appServices = typeof(Startup).Assembly
                                             .DefinedTypes
                                             .Where(x => typeof(IServiceRegistration).IsAssignableFrom(x)
                                                      && !x.IsInterface
                                                      && !x.IsAbstract)
                                             .Select(Activator.CreateInstance)
                                             .Cast<IServiceRegistration>()
                                             .ToList();

            appServices.ForEach(appService => appService.Register(services, configuration));
        }
    }
}