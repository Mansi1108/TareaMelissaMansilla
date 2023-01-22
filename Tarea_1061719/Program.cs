using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tarea_1061719;
using Tarea_1061719.Clases;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<IServicioTransient, Juegos>();
        services.AddScoped<IServicioScoped, Control>();
        services.AddScoped<IServicioScoped, Control2>();
        services.AddSingleton<IServicioSingleton, Consola>();
        services.AddSingleton<IServicioSingleton, Consola2>();
        services.AddTransient<Reporter>();
    })
    .Build();

ExemplifyServiceLifetime(host.Services, "Lifetime 1");
ExemplifyServiceLifetime(host.Services, "Lifetime 2");

await host.RunAsync();

static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    Reporter logger = provider.GetRequiredService<Reporter>();
    logger.ReportDetails(
        $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeLogger>()");

    Console.WriteLine("...");

    logger = provider.GetRequiredService<Reporter>();
    logger.ReportDetails(
        $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeLogger>()");

    Console.WriteLine();
}
