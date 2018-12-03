using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Puzzles.Day01;

namespace AdventOfCodeTests.Puzzles
{
    [TestClass]
    public class Day01Tests
    {
        [TestMethod]
        public void TestPartOneSolutionIsCorrect()
        {
            // Arrange
            // Act
            var part1Solution = Solution.Part1();

            // Assert
            Assert.AreEqual(442, part1Solution);
        }

        [TestMethod]
        public void TestPartTwoSolutionIsCorrect()
        {
            // Arrange
            // Act
            var part2Solution = Solution.Part2();

            // Assert
            Assert.AreEqual(59908, Solution.Part2());
        }
    }
}
