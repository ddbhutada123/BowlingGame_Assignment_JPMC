using JPMC_BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JPMC_BowlingTest
{
    /// <summary>
    /// Bowling Test Class
    /// </summary> 
    [TestClass]
    public class BowlingTest
    {
        private Bowling bowling;

        /// <summary>
        /// Test Set up
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            bowling = new Bowling();
        }

        [TestMethod]
        public void TestJPMCBowlingGame()
        {
            bowling.Roll(new int[] { 5, 4, 3, 6, 10, 2, 6, 5, 3, 5, 4, 8, 2, 7, 2, 10, 7, 0 });
            Assert.AreEqual(111, bowling.GetScore());
        }

        [TestMethod]
        public void TestJPMCBowlingGameWithSpareFollwedByStrikeAtEnd()
        {
            bowling.Roll(new int[] { 3, 5, 7, 3, 10, 1, 7, 5, 2, 6, 3, 7, 3, 6, 2, 10, 9, 1, 10 });
            Assert.AreEqual(134, bowling.GetScore());
        }

        /// <summary>
        /// Test Clean up
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            bowling = null;
        }
    }
}
