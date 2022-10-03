using Microsoft.Extensions.DependencyInjection;

namespace Strategy.Managers;

internal class DuckGeneratorApp
{
    private readonly ConsoleManager _consoleManager;
    private readonly ConsoleKeyManager _consoleKeyManager;
    private readonly IServiceProvider _serviceProvider;

    public DuckGeneratorApp(ConsoleManager consoleManager, ConsoleKeyManager consoleKeyManager, IServiceProvider serviceProvider)
    {
        _consoleManager = consoleManager;
        _consoleKeyManager = consoleKeyManager;
        _serviceProvider = serviceProvider;
    }

    public void CrateDucksByConsoleSelection()
    {
        _consoleManager.WriteHeadlineToConsole();

        bool canAppContinue = true;

        while (canAppContinue)
        {
            _consoleManager.WriteAppControlCommands();

            var pushedKey = _consoleManager.GetValidPushedKey();

            if (_consoleKeyManager.IsQuitKeyPushed(pushedKey))
            {
                canAppContinue = false;

                continue;
            }

            var duck = _serviceProvider.GetService<DuckFactory>().Create(pushedKey);

            duck.Fly();
        }
    }
}