using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Strategy.Managers;
using Strategy.Models;
using Strategy.Strategies.Fly;

var builder = Host.CreateDefaultBuilder(args);

RegisterServices(builder);

var host = builder.Build();

var duckGenerator = host.Services.GetRequiredService<DuckGeneratorApp>();
duckGenerator.CrateDucksByConsoleSelection();

void RegisterServices(IHostBuilder hostBuilder)
{
    hostBuilder.ConfigureServices(
        services =>
            services.AddScoped<Duck>()
                .AddScoped<DuckGeneratorApp>()
                .AddScoped<ConsoleManager>()
                .AddScoped<ConsoleKeyManager>()
                .AddScoped<DuckFactory>()
                .AddScoped<SlowFlyStrategy>()
                .AddScoped<JetFlyStrategy>());
}