using Microsoft.Extensions.Configuration;

namespace ConsoleAppDP.Services
{
    public class Service : IService
    {
        private readonly IConfiguration _configuration;
        public Service(IConfiguration config)
        {
            _configuration = config;
        }

        public void HelloWorld(string param1, string param2)
        {
            var message = _configuration["Message"];
            Console.WriteLine($"{message} {param1} {param2}");
        }
    }
}
