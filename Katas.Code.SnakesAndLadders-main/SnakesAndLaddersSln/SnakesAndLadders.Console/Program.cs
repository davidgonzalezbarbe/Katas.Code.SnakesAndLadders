using Microsoft.Extensions.DependencyInjection;
using SnakesAndLadders.Console.Class;
using SnakesAndLadders.Console.DI;
using SnakesAndLadders.Console.Interface;
using SnakesAndLadders.Core.Class;
using SnakesAndLadders.Core.Interface;

class Program
{
    public static void Main(string[] args)
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<IGameConsole, GameConsole>();
        serviceCollection.AddSingleton<IGame, Game>();
        Injector.GenerarProveedor(serviceCollection);
        var game = Injector.GetService<IGameConsole>();

        var exit = false;
        WriteInConsole("\r\n\r\n   _____             _                                _ _               _     _               \r\n  / ____|           | |               /\\             | | |             | |   | |              \r\n | (___  _ __   __ _| | _____  ___   /  \\   _ __   __| | |     __ _  __| | __| | ___ _ __ ___ \r\n  \\___ \\| '_ \\ / _` | |/ / _ \\/ __| / /\\ \\ | '_ \\ / _` | |    / _` |/ _` |/ _` |/ _ \\ '__/ __|\r\n  ____) | | | | (_| |   <  __/\\__ \\/ ____ \\| | | | (_| | |___| (_| | (_| | (_| |  __/ |  \\__ \\\r\n |_____/|_| |_|\\__,_|_|\\_\\___||___/_/    \\_\\_| |_|\\__,_|______\\__,_|\\__,_|\\__,_|\\___|_|  |___/\r\n                                                                                              \r\n");
        WriteInConsole("\r\nCommands:\r\n- Enter key: start game.\r\n- Exit key: end game.\r\n- M key: move the player.");
        WriteInConsole("\r\n\r\n");
        do
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Escape:
                        WriteInConsole(game.Exit());
                        exit = true;
                        break;

                    case ConsoleKey.Enter:
                        WriteInConsole(game.Start());
                        break;

                    case ConsoleKey.M:
                        WriteInConsole(game.Move());
                        break;

                    default:
                        WriteInConsole(game.InvalidCommand());
                        break;
                }
            }
        } while (exit == false);
    }

    /// <summary>
    /// Method to write to the console.
    /// </summary>
    /// <param name="value">Value to write.</param>
    private static void WriteInConsole(string value)
    {
        Console.WriteLine(value);
    }
}