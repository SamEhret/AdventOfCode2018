using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Puzzles.Day03;

namespace AdventOfCodeTests.Puzzles
{
    [TestClass]
    public class Day03Tests
    {
        [TestMethod]
        public void TestPartOneSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part1();

            // Assert
            Assert.AreEqual(110195, solution);
        }

        [TestMethod]
        public void TestPartTwoSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part2();

            // Assert
            Assert.AreEqual(894, solution);
        }
    }
}
