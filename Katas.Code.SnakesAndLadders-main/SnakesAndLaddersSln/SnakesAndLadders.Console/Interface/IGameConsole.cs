using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Console.Interface
{
    internal interface IGameConsole
    {
        /// <summary>
        /// Method to start the game.
        /// </summary>
        /// <returns>Text to paint in console.</returns>
        string Start();

        /// <summary>
        /// Method to move the user.
        /// </summary>
        /// <returns>Text to paint in console.</returns>
        string Move();

        /// <summary>
        /// Method to end the game.
        /// </summary>
        /// <returns>Text to paint in console.</returns>
        string Exit();

        /// <summary>
        /// Method when you press an unrecognized command.
        /// </summary>
        /// <returns>Text to paint in console.</returns>
        string InvalidCommand();
    }
}
