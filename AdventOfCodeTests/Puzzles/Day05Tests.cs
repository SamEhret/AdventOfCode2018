using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Puzzles.Day05;

namespace AdventOfCodeTests.Puzzles
{
    [TestClass]
    public class Day05Tests
    {
        [TestMethod]
        public void TestPartOneSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part1();

            // Assert
            Assert.AreEqual(10972, solution);
        }

        [TestMethod]
        public void TestPartTwoSolutionIsCorrect()
        {
            // Arrange
            // Act
            var solution = Solution.Part2();

            // Assert
            Assert.AreEqual(5278, solution);
        }
    }
}
