using ConsoleAppDP.Infrastructure;
using ConsoleAppDP.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
{
    services.RegisterAppServices();

}).Build();

var myService = host.Services.GetService<IService>();

Console.Write("Enter param1: ");
string param1 = Console.ReadLine();

Console.Write("Enter param2: ");
string param2 = Console.ReadLine();

myService.HelloWorld(param1, param2);

await host.RunAsync();