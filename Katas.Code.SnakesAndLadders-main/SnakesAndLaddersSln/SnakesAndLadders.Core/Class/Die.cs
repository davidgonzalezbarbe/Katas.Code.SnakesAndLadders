namespace SnakesAndLadders.Core.Class
{
    /// <summary>
    /// Class die to generate moves
    /// </summary>
    internal class Die
    {
        #region Private Properties

        private Random _rnd = new ();
        private int MIN_VALUE = 1;
        private int MAX_VALUE = 6;

        #endregion

        /// <summary>
        /// Generates a random move between 1 and 6.
        /// </summary>
        public int Roll()
        {
            return _rnd.Next(MIN_VALUE, MAX_VALUE);
        }
    }
}
