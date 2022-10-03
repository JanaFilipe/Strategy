using Strategy.Managers;

namespace Strategy.Strategies.Fly;

internal abstract class FlyStrategy : IFlyStrategy
{
    private readonly ConsoleManager _consoleManager;

    protected FlyStrategy(ConsoleManager consoleManager)
    {
        _consoleManager = consoleManager;
    }

    public virtual void Fly()
    {
        Console.Write("Tato kachna létá: ");

        this._consoleManager.SetDuckTextColor();
    }
}