namespace SnakesAndLadders.Core.Class
{
    /// <summary>
    /// Class for player control.
    /// </summary>
    internal class Player
    {
        #region Constant

        /// <summary>
        /// Maximum position that the player can reach.
        /// </summary>
        private const int MAX_POSITION = 100;

        #endregion

        #region Public Properties
        
        /// <summary>
        /// Get the current position of the player.
        /// </summary>
        public int Position => _Position;

        #endregion


        #region Private Properties

        private int _Position { get; set; }

        #endregion

        /// <summary>
        /// Generate a new player.
        /// </summary>
        public Player()
        {
            this._Position = 1;
        }

        /// <summary>
        /// Perform a move on the player, as long as it does not exceed the value 100.
        /// </summary>
        /// <param name="position">Number of positions to move the player.</param>
        public void Move(int position)
        {
            if (this._Position + position > MAX_POSITION) return;
            this._Position += position;
        }

        /// <summary>
        /// Check if the player has won by being in position 100.
        /// </summary>
        public bool IsWin()
        {
            return this._Position == MAX_POSITION;
        }
    }
}