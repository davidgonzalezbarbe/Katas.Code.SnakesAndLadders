namespace SnakesAndLadders.Core.Interface
{
    /// <summary>
    /// Main class for game control.
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Method to start or restart the game
        /// </summary>
        void Start();

        /// <summary>
        /// Method to get the user's position
        /// </summary>
        /// <exception cref="Exception">Exception produced by the absence of player.
        /// You must first call the AddUserOnTheBoard() method.</exception>
        void AddUserOnTheboard();

        /// <summary>
        /// Method to get the user's position
        /// </summary>
        /// <exception cref="Exception">Exception produced by the absence of player.
        /// You must first call the AddUserOnTheBoard() method.</exception>
        int GetPosition();

        /// <summary>
        /// Moves the player the positions indicated by parameters
        /// </summary>
        /// <param name="movement">Number of movements to move the player.</param>
        /// <exception cref="Exception">Exception produced by the absence of player.
        /// You must first call the AddUserOnTheBoard() method.</exception>
        void MoveUser(int movement);

        /// <summary>
        /// Check if the player has won.
        /// </summary>
        /// <exception cref="Exception">Exception produced by the absence of player.
        /// You must first call the AddUserOnTheBoard() method.</exception>
        bool IsWin();

        /// <summary>
        /// Roll the dice to return a random value between 1 and 6.
        /// </summary>
        /// <returns>The result of the die roll.</returns>
        int RollDie();
    }
}
