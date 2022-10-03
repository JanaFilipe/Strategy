using Strategy.Managers;

namespace Strategy.Strategies.Fly;

internal class JetFlyStrategy : FlyStrategy
{
    public JetFlyStrategy(ConsoleManager consoleManager) : base(consoleManager)
    {
    }

    public override void Fly()
    {
        base.Fly();

        Console.WriteLine("frnk");
    }
}