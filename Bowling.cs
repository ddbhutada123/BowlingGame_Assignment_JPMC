namespace JPMC_BowlingGame
{
    /// <summary>
    /// Bowling Business Class
    /// </summary>
    public class Bowling : IBowling
    {
        private readonly int[] rolls = new int[21]; // 2 for first 9 frame and 3 for 10th frame
        private const int frameCount = 10; // Total Frame Count

        /// <summary>
        /// Get Total Bowling score
        /// </summary>
        /// <returns>Returns Total Bowling score</returns>
        public int GetScore()
        {
            int frameIndex = 0;
            int bowlingScore = 0;
            for (int frame = 0; frame < frameCount; frame++)
            {
                if (BusinessHelper.isStrike(rolls[frameIndex]))
                {
                    bowlingScore += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex++;
                }
                else if (BusinessHelper.isSpare(rolls[frameIndex], rolls[frameIndex + 1]))
                {
                    bowlingScore += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    bowlingScore += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return bowlingScore;
        }

        /// <summary>
        /// Set Rolls index for each pin
        /// </summary>
        /// <param name="pins">Array of Pins</param>
        public void Roll(int[] pins)
        {
            for (int i = 0; i < pins.Length; i++)
            {
                rolls[i] = pins[i];
            }
        }
    }
}
