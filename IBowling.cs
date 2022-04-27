namespace JPMC_BowlingGame
{
    /// <summary>
    /// Interface For Bowling Business Class
    /// </summary>
    public interface IBowling
    {
        /// <summary>
        /// Get Total Bowling score
        /// </summary>
        /// <param name="frameIndex">Frame Index</param>
        /// <returns>Returns Total Bowling score</returns>
        int GetScore();

        /// <summary>
        /// Set Rolls index for each pin
        /// </summary>
        /// <param name="pins">Array of Pins</param>
        void Roll(int[] pins);
    }
}
