namespace BowlingApp
{
    public interface IBowlingGame
    {
        /// <summary>
        /// Add score to current roll
        /// </summary>
        /// <param name="pins"></param>
        void AddRollScore(int pins);

        /// <summary>
        /// Get the Score for valid completed game
        /// </summary>
        /// <returns></returns>
        int GetScore();

    }
}
