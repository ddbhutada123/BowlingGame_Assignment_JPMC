namespace JPMC_BowlingGame
{
    /// <summary>
    /// Bowling Business Helper Class
    /// </summary>
    public static class BusinessHelper
    {
        /// <summary>
        /// To check if Roll is Spare
        /// </summary>
        /// <param name="currentFrameIndexValue">Current Frame Index Value</param>
        /// <param name="nextFrameIndexValue">Next Frame Index Value</param>
        /// <returns>Returns true if Roll is Spare else false</returns>
        public static bool isSpare(int currentFrameIndexValue, int nextFrameIndexValue)
        {
            return currentFrameIndexValue + nextFrameIndexValue == 10;
        }

        /// <summary>
        /// To check if Roll is Strike
        /// </summary>
        /// <param name="currentFrameIndexValue">Current Frame Index Value</param>
        /// <returns>Returns true if Roll is Strike else false</returns>
        public static bool isStrike(int currentFrameIndexValue)
        {
            return currentFrameIndexValue == 10;
        }
    }
}
