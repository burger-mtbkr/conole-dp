using ConsoleAppDP.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppDP.Infrastructure
{
    public static class AppServiceRegistration
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection services)
        {
            services.AddSingleton(AppConfigurationProvider.RegisterAppConfiguration());
            services.AddScoped<IService, Service>();

            return services;
        }
    }
}
