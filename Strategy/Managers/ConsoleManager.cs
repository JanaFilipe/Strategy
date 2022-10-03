namespace Strategy.Managers;

internal class ConsoleManager
{
    private readonly ConsoleKeyManager _consoleKeyManager;

    public ConsoleManager(ConsoleKeyManager consoleKeyManager)
    {
        _consoleKeyManager = consoleKeyManager;
    }

    public void WriteHeadlineToConsole()
    {
        SetDuckTextColor();

        Console.WriteLine(@" =(^ )___,
  (  \)  )
~~~~~~~~~~~~~");
    }

    public void WriteAppControlCommands()
    {
        SetDefaultTextColor();

        Console.WriteLine(string.Empty);
        Console.WriteLine("Stisknětě klávesu pro výběr kachny:");
        Console.WriteLine("H - horská");
        Console.WriteLine("J - jezerní");
        Console.WriteLine("Pro ukončení aplikace stiskněte Q.");
    }

    public ConsoleKey GetValidPushedKey()
    {
        ConsoleKey key = 0;
        bool isKeyValid = false;

        while (!isKeyValid)
        {
            key = ReadUserCommand();

            isKeyValid = _consoleKeyManager.IsKeyValid(key);

            if (!isKeyValid)
            {
                Console.WriteLine("Stisknutá klávesa není platná. Stiskněte klávesu znovu.");
            }
        }

        return key;
    }

    private ConsoleKey ReadUserCommand()
    {
        var keyInfo = Console.ReadKey();

        Console.WriteLine(string.Empty);

        return keyInfo.Key;
    }

    private void SetDefaultTextColor()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void SetDuckTextColor()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}