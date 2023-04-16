using Microsoft.Extensions.Configuration;

namespace ConsoleAppDP.Infrastructure
{
    public static class AppConfigurationProvider
    {
        public static IConfiguration RegisterAppConfiguration() =>
            new ConfigurationBuilder()
             .AddJsonFile("appsettings.json",
             optional: true,
             reloadOnChange: true)
             .Build();
    }
}
