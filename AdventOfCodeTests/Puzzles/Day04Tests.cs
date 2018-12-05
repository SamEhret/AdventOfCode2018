using AdventOfCode.Puzzles.Day04;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCodeTests.Puzzles
{
    [TestClass]
    public class Day04Tests
    {
        [TestMethod]
        public void TestPartOneSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part1();

            // Assert
            Assert.AreEqual(109659, solution);
        }

        [TestMethod]
        public void TestPartTwoSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part2();

            // Assert
            Assert.AreEqual(36371, solution);
        }
    }
}
