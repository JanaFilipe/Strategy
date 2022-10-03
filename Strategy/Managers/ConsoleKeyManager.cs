namespace Strategy.Managers;

internal class ConsoleKeyManager
{
    public bool IsQuitKeyPushed(ConsoleKey key)
    {
        return key == ConsoleKey.Q;
    }

    public bool IsKeyValid(ConsoleKey key)
    {
        var validKeys = new List<ConsoleKey>{ ConsoleKey.Q,
            ConsoleKey.H,
            ConsoleKey.J };

        return validKeys.Contains(key);
    }
}