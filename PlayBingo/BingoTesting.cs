using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PlayBingo
{
    [TestFixture]
    public class BingoTesting
    {
        BingoGame game = new BingoGame();

        [Test]
        public void ConfirmThatTheNumberIsBetweenOneAndSeventyFiveIclusive()
        {
            int largestValue = 75;
            int lowestValue = 1;
            int output = game.PlayGame();

            Assert.GreaterOrEqual(largestValue, output);
            Assert.LessOrEqual(lowestValue, output);
        }

        [Test]
        public void CallCorrectNumbersMulitpleTimes()
        {
            int expected = 75;
            int output = game.PlayGame();

            Assert.AreEqual(expected, output);
        }
    }
}
