using Microsoft.Extensions.DependencyInjection;
using Strategy.Models;
using Strategy.Strategies.Fly;

namespace Strategy.Managers;

internal class DuckFactory
{
    private readonly IServiceProvider _serviceProvider;

    public DuckFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Duck Create(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.H:
                return CreateMountainDuck();

            case ConsoleKey.J:
                return CreateLakeDuck();

            default:
                throw new NotImplementedException($"{nameof(DuckFactory)}.{nameof(Create)}");
        }
    }

    private Duck CreateMountainDuck()
    {
        var flyStrategy = _serviceProvider.GetService<JetFlyStrategy>();

        return new Duck(flyStrategy);
    }

    private Duck CreateLakeDuck()
    {
        var flyStrategy = _serviceProvider.GetService<SlowFlyStrategy>();

        return new Duck(flyStrategy);
    }

}