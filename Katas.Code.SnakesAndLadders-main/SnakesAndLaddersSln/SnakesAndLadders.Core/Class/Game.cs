using SnakesAndLadders.Core.Globalization;
using SnakesAndLadders.Core.Interface;

namespace SnakesAndLadders.Core.Class
{
    /// <summary>
    /// Main class for game control.
    /// </summary>
    public class Game : IGame
    {
        #region Private properties

        private Die _die = new();
        private List<Player> _players = new();

        #endregion

        /// <summary>
        /// Method to start or restart the game
        /// </summary>
        public void Start()
        {
            _players = new List<Player>();
        }

        /// <summary>
        /// Method to add the player to the game
        /// </summary>
        public void AddUserOnTheboard()
        {
            var newUser = new Player();
            _players.Add(newUser);
        }

        /// <summary>
        /// Method to get the user's position
        /// </summary>
        /// <exception cref="Exception">Exception produced by the absence of player.
        /// You must first call the AddUserOnTheBoard() method.</exception>
        public int GetPosition()
        {
            Validation();
            return _players.First().Position;
        }

        /// <summary>
        /// Moves the player the positions indicated by parameters
        /// </summary>
        /// <param name="movement">Number of movements to move the player.</param>
        /// <exception cref="Exception">Exception produced by the absence of player.
        /// You must first call the AddUserOnTheBoard() method.</exception>
        public void MoveUser(int movement)
        {
            Validation();
            var user = _players.First();
            user.Move(movement);
        }

        /// <summary>
        /// Check if the player has won.
        /// </summary>
        /// <exception cref="Exception">Exception produced by the absence of player.
        /// You must first call the AddUserOnTheBoard() method.</exception>
        public bool IsWin()
        {
            Validation();
            return _players.First().IsWin();
        }

        /// <summary>
        /// Roll the dice to return a random value between 1 and 6.
        /// </summary>
        /// <returns>The result of the die roll.</returns>
        public int RollDie()
        {
            return _die.Roll();
        }

        /// <summary>
        /// Method for previous validations.
        /// </summary>
        /// <exception cref="Exception">Exception produced by the absence of player.
        /// You must first call the AddUserOnTheBoard() method.</exception>
        private void Validation()
        {
            if (!_players.Any()) throw new Exception(EN.NoPlayerCreated);
        }
    }
}