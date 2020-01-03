using NUnit.Framework;
using RabbitTask2__Collections;

namespace TDD_RabbitTask2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        #region TestRabbitGrowth
        [TestCase(3,7,8)]
        public void RabbitGrowthTests(int totalYears, int expectedRabbitAge, int expectedRabbitCount)
        {
            // Use of TUPLE (int Name, int Name)
            (int actualCumulativeAge, int actualRabbitCount) = RabbitCollection.MultiplyRabbits(totalYears);
            //Assert
            Assert.AreEqual(expectedRabbitAge, actualCumulativeAge);
            Assert.AreEqual(expectedRabbitCount, actualRabbitCount);
        }
        #endregion

        #region Test_RabbitGrowth_NotBeginUntilThreeYearsAge
        [TestCase(3, 3, 1)]
        [TestCase(4, 4, 2)]
        [TestCase(5, 6, 3)]
        [TestCase(6, 9, 4)]
        public void RabbitGrowthAfterThreeYears(int totalYears, int expectedRabbitAge, int expectedRabbitCount)
        {
            // Using TUPLE (int Name, int Name)
            (int actualCumulativeAge, int actualRabbitCount) =
             RabbitCollection.MultiplyRabbitsAfterAgeThreeReached(totalYears);
            // Assert
            Assert.AreEqual(expectedRabbitAge, actualCumulativeAge);
            Assert.AreEqual(expectedRabbitCount, actualRabbitCount);
        }
        #endregion
    }
}