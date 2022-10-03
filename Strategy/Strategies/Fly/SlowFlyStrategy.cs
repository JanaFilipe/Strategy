using Strategy.Managers;

namespace Strategy.Strategies.Fly;

internal class SlowFlyStrategy : FlyStrategy
{
    public SlowFlyStrategy(ConsoleManager consoleManager) : base(consoleManager)
    {
    }

    public override void Fly()
    {
        base.Fly();

        Console.WriteLine("p o m a l u");
    }
}