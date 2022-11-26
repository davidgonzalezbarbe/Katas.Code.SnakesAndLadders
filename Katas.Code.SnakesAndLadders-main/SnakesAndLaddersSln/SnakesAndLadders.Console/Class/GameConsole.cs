using SnakesAndLadders.Console.Globalization;
using SnakesAndLadders.Console.Interface;
using SnakesAndLadders.Core.Interface;

namespace SnakesAndLadders.Console.Class
{
    internal class GameConsole : IGameConsole
    {
        private readonly IGame _game;

        public GameConsole(IGame game)
        {
            _game = game;
        }

        /// <summary>
        /// Method to start the game.
        /// </summary>
        /// <returns>Text to paint in console.</returns>
        public string Start()
        {
            _game.Start();
            _game.AddUserOnTheboard();
            var position = _game.GetPosition();
            return Environment.NewLine + string.Format(EN.StartCommand, position);
        }

        /// <summary>
        /// Method to move the user.
        /// </summary>
        /// <returns>Text to paint in console.</returns>
        public string Move()
        {
            try
            {
                var move = _game.RollDie();
                var initial = _game.GetPosition();
                _game.MoveUser(move);
                var final = _game.GetPosition();
                return _game.IsWin() ? Environment.NewLine + string.Format(EN.WinGame) : Environment.NewLine + string.Format(EN.MoveCommand, move, initial, final);
            }
            catch (Exception)
            {
                return Environment.NewLine + string.Format(EN.ErrorWinNotStarted);
            }

        }

        /// <summary>
        /// Method to end the game.
        /// </summary>
        /// <returns>Text to paint in console.</returns>
        public string Exit() => Environment.NewLine + EN.ExitCommand;

        /// <summary>
        /// Method when you press an unrecognized command.
        /// </summary>
        /// <returns>Text to paint in console.</returns>
        public string InvalidCommand() => Environment.NewLine + EN.InvalidCommand;
    }
}
