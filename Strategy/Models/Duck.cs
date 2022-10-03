using Strategy.Strategies.Fly;

namespace Strategy.Models;

internal class Duck
{
    private readonly IFlyStrategy _flyStrategy;

    public Duck(IFlyStrategy flyStrategy)
    {
        _flyStrategy = flyStrategy;
    }

    public void Fly()
    {
        _flyStrategy.Fly();
    }
}